using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
{
    public class NahieManagmentController : Controller
    {
        IUnitofWork _context;

        public NahieManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index(int id)
        {
            ViewData["Id"] = id;
            if (id==0)
            {
                return View(await _context.NahieRepository.GetManyAsyncWithInclude("City"));
            }
            return View(_context.NahieRepository.GetAllWithWhereandInclude("City",a => a.CityId==id));
        }

        public async Task<IActionResult> Create(int cityid)
        {
            if (cityid==0)
            {
                return RedirectToAction("Index","CityManagment");
            }
            ViewData["Id"] = cityid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Nahie nahie, IFormFile Icon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Icon!=null)
                    {
                        var fileName = Guid.NewGuid() + Icon.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Icon.CopyToAsync(stream);

                        }
                        nahie.Icon = fileName;
                    }
                    _context.NahieRepository.Insert(nahie);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "NahieManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.NahieRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "NahieManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        public async Task<IActionResult> Update(int id)
        {
            ViewData["Id"] = id;
            return View(_context.NahieRepository.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Nahie nahie, IFormFile UpdateIcon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (UpdateIcon != null)
                    {
                        var fileName = Guid.NewGuid() + UpdateIcon.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await UpdateIcon.CopyToAsync(stream);
                        }
                        nahie.Icon = fileName;
                    }
                    _context.NahieRepository.Update(nahie);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "NahieManagment",
                    LogText = ex.ToString(),
                    LogView = "UpdateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
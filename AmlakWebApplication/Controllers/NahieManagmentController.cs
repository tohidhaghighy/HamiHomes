using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.City;

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
            if (id == 0)
            {
                return View(await _context.NahieRepository.GetManyAsyncWithInclude("City"));
            }
            return View(_context.NahieRepository.GetAllWithWhereandInclude("City", a => a.CityId == id));
        }

        public async Task<IActionResult> ListDirection(int nahieid)
        {
            var nahielist = new ViewModelLayer.City.NahieDirect();
            nahielist.nahieid = nahieid;
            nahielist.OnlyThisNahieDirections = await _context.NahieDirectionRepository.GetManyAsync(a => a.NahieId == nahieid && a.Type==0);
            nahielist.NahieDirections= await _context.NahieDirectionRepository.GetManyAsync(a => a.Type == 0);
            nahielist.Nahie = await _context.NahieRepository.GetAllAsync();
            return View(nahielist);
        }

        public async Task<IActionResult> Create(int cityid)
        {
            if (cityid == 0)
            {
                return RedirectToAction("Index", "CityManagment");
            }
            ViewData["Id"] = cityid;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CreateItem(int cityid, string name)
        {
            try
            {
                var nahie = new Nahie();
                nahie.Gpsx = "";
                nahie.Gpsy = "";
                nahie.Name = name;
                nahie.CityId = cityid;
                _context.NahieRepository.Insert(nahie);
                await _context.CommitAsync();
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
        public async Task<IActionResult> InsertDirection(int nahieid, string gpsx, string gpsy)
        {
            try
            {
                var nahiedir = new NahieDirections();
                nahiedir.Gpsx = gpsx;
                nahiedir.Gpsy = gpsy;
                nahiedir.NahieId = nahieid;
                nahiedir.Type = 0;
                _context.NahieDirectionRepository.Insert(nahiedir);
                await _context.CommitAsync();
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNahieItem(NahieDirections nahie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.NahieDirectionRepository.Insert(nahie);
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

        [HttpPost]
        public async Task<Boolean> DeleteDirection(int id)
        {
            try
            {
                _context.NahieDirectionRepository.Delete(id);
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
                        nahie.Icon = ImageUrl.url + fileName;
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


        public async Task<PartialViewResult> AddDirection(int nahieid, string gpsx, string gpsy, int cityid, string text)
        {
            var nah = new Nahie();
            var nahiedirectinfo = new NahieDirect();
            var nahie = new NahieDirections();
            if (nahieid == 0)
            {
                nah.CityId = cityid;
                nah.Gpsx = gpsx;
                nah.Gpsy = gpsy;
                nah.Icon = "";
                nah.Name = text;
                _context.NahieRepository.Insert(nah);
                await _context.CommitAsync();
                nahie.NahieId = nah.Id;
            }
            else
            {
                nahie.NahieId = nahieid;
            }

            nahie.Gpsx = gpsx;
            nahie.Gpsy = gpsy;
            _context.NahieDirectionRepository.Insert(nahie);
            await _context.CommitAsync();
            nahiedirectinfo.nahieid = nahie.NahieId;
            nahiedirectinfo.NahieDirections = await _context.NahieDirectionRepository.GetManyAsync(a => a.NahieId == nahie.NahieId);
            return PartialView("_ListDirectionNahie", nahiedirectinfo);
        }
    }
}
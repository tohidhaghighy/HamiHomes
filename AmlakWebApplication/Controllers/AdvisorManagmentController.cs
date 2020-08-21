using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Hash;

namespace AmlakWebApplication.Controllers
{
    public class AdvisorManagmentController : Controller
    {
        IUnitofWork _context;

        public AdvisorManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.AdviserRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.AdviserRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Adviser adviser, IFormFile Image, IFormFile BackgroundImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Image != null)
                    {
                        var fileName = Guid.NewGuid() + Image.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Image.CopyToAsync(stream);

                        }
                        adviser.Image = fileName;
                    }

                    if (BackgroundImage != null)
                    {
                        var fileName = Guid.NewGuid() + BackgroundImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await BackgroundImage.CopyToAsync(stream);

                        }
                        adviser.BackgroundImage = fileName;
                    }

                    adviser.Password = adviser.Password.GetHashPassword();
                    _context.AdviserRepository.Insert(adviser);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<Boolean> ChangeCheck(int id)
        {
            try
            {
                await _context.AdviserRepository.ChangeCheck(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "ChangeCheck"
                });
            }
            return false;
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
{
    public class HomeGalleryManagmentController : Controller
    {

        IUnitofWork _context;

        public HomeGalleryManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index(int homeid)
        {
            ViewData["Id"] = homeid;
            return View(await _context.HomeGalleryRepository.GetManyAsync(a=>a.HomeId==homeid));
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.HomeGalleryRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "GalleryManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(HomeGallery gallery, IFormFile Image)
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
                        gallery.Url = ImageUrl.url + fileName;

                        _context.HomeGalleryRepository.Insert(gallery);
                        await _context.CommitAsync();
                    }

                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "GalleryManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index),"HomeGalleryManagment",new { homeid=gallery.HomeId});
        }
    }
}
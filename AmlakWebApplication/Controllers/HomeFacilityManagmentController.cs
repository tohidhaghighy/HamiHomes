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

namespace AmlakWebApplication.Controllers
{
    public class HomeFacilityManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeFacilityManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeFacilityRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(HomeFacility homefacility, IFormFile Icon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Icon != null)
                    {
                        var fileName = Guid.NewGuid() + Icon.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Icon.CopyToAsync(stream);
                        }
                        homefacility.Icon = fileName;
                    }
                    _context.HomeFacilityRepository.Insert(homefacility);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeFacilityManagment",
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
                _context.HomeFacilityRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeFacilityManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

    }
}
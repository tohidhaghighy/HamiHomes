using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
{
    public class HomeGroupManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeGroupManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeGroupRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(HomeGroup homegroup, IFormFile Icon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Icon!=null)
                    {
                        var fileName = Guid.NewGuid() + Icon.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Icon.CopyToAsync(stream);
                        }
                        homegroup.Icon = fileName;
                    }
                    _context.HomeGroupRepository.Insert(homegroup);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeGroupManagment",
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
                _context.HomeGroupRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeGroupManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

    }
}
using System;
using System.Collections.Generic;
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
    public class MahalleManagmentController : Controller
    {
        IUnitofWork _context;

        public MahalleManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index(int id)
        {
            ViewData["Id"] = id;
            if (id==0)
            {
                return View(await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie"));
            }
            return View(_context.MahalleRepository.GetAllWithWhereandInclude("Nahie",a =>a.NahieId==id));
        }

        public async Task<IActionResult> Create(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index", "CityManagment");
            }
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Mahalle mahalle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.MahalleRepository.Insert(mahalle);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "MahalleManagment",
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
                _context.MahalleRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "MahalleManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

    }
}
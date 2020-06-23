using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
{
    public class SettingManagmentController : Controller
    {
        IUnitofWork _context;

        public SettingManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SettingRepository.GetFirstAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Setting setting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.SettingRepository.Update(setting);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "SettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Update"
                });

            }
            return RedirectToAction(nameof(Index));
        }

    }
}
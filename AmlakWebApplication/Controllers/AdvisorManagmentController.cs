using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
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
        public async Task<IActionResult> CreateItem(Adviser adviser)
        {
            try
            {
                if (ModelState.IsValid)
                {
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
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
    public class UserManagmentController : Controller
    {
        IUnitofWork _context;

        public UserManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Active = true;
                    user.Activecode = "0000000000";
                    _context.UserRepository.Insert(user);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "UserManagment",
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
                _context.UserRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "UserManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        public async Task<Boolean> ChangeCheck(int id)
        {
            try
            {
                await _context.UserRepository.ChangeCheck(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "UserManagment",
                    LogText = ex.ToString(),
                    LogView = "ChangeCheck"
                });
            }
            return false;
        }

    }
}
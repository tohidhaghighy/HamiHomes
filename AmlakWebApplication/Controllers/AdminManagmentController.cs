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
    public class AdminManagmentController : Controller
    {
        IUnitofWork _context;

        public AdminManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.AdminRepository.GetAllAsync());
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
                _context.AdminRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdminManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Admin admin,int AdminType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    admin.Password = admin.Password.GetHashPassword();
                    if (AdminType==1)
                    {
                        admin.AdminType = DomainLayer.Enums.AdminType.GoldenAdmin;
                    }else{
                        admin.AdminType = DomainLayer.Enums.AdminType.BoronzAdmin;
                    }
                    _context.AdminRepository.Insert(admin);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdminManagment",
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
                await _context.AdminRepository.ChangeCheck(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdminManagment",
                    LogText = ex.ToString(),
                    LogView = "ChangeCheck"
                });
            }
            return false;
        }

    }
}
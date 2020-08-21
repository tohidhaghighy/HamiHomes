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
    public class CostSettingController : Controller
    {
        IUnitofWork _context;

        public CostSettingController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.CostSettingRepository.GetAllAsync());
        }

        public async Task<IActionResult> CreateCost()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItemCost(CostSetting costSetting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.CostSettingRepository.Insert(costSetting);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CostSettingManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<Boolean> DeleteCost(int id)
        {
            try
            {
                _context.CostSettingRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CostsettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }


        public async Task<IActionResult> Metraz()
        {
            return View(await _context.MetrazSettingRepository.GetAllAsync());
        }

        public async Task<IActionResult> CreateMetraz()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItemMetraz(MetrazSetting metrazSetting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.MetrazSettingRepository.Insert(metrazSetting);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "MetrazSettingManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Metraz));
        }


        [HttpPost]
        public async Task<Boolean> DeleteMetraz(int id)
        {
            try
            {
                _context.MetrazSettingRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "metrazsettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        public async Task<IActionResult> Ejare()
        {
            return View(await _context.EjareSettingRepository.GetAllAsync());
        }

        public async Task<IActionResult> CreateEjare()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItemEjare(EjareSetting ejaresetting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.EjareSettingRepository.Insert(ejaresetting);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "EjareSettingManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Ejare));
        }

        [HttpPost]
        public async Task<Boolean> DeleteEjare(int id)
        {
            try
            {
                _context.EjareSettingRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "ejaresettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        public async Task<IActionResult> Vadie()
        {
            return View(await _context.VadieSettingRepository.GetAllAsync());
        }

        public async Task<IActionResult> CreateVadie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItemVadie(VadieSetting vadiesetting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.VadieSettingRepository.Insert(vadiesetting);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "VadieSettingManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Vadie));
        }

        [HttpPost]
        public async Task<Boolean> DeleteVadie(int id)
        {
            try
            {
                _context.VadieSettingRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "vadiesettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

    }
}
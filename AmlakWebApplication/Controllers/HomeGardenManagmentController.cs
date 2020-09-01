using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.Home;

namespace AmlakWebApplication.Controllers
{
    public class HomeGardenManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeGardenManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeGardenRepository.GetManyAsyncWithInclude("Home"));
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var Garden = new GardenFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            Garden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(Garden);
        }

        public async Task<IActionResult> Update(int id)
        {
            var Garden = new GardenFacility();
            Garden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Garden.Garden = _context.HomeGardenRepository.GetById(id);
            return View(Garden);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Garden garden, int HomeId,string[] emtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    garden.HomeEmtiaz = string.Join(" , ", emtiaz);
                    garden.HomeId = HomeId;
                    _context.HomeGardenRepository.Insert(garden);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeGardenManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Garden garden, string[] emtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    garden.HomeEmtiaz = string.Join(" , ", emtiaz);
                    _context.HomeGardenRepository.Update(garden);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = garden.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeGardenManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.HomeGardenRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeEdariManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }
    }
}
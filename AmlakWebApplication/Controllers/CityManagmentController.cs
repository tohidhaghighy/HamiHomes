using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.City;

namespace AmlakWebApplication.Controllers
{
    public class CityManagmentController : Controller
    {
        IUnitofWork _context;

        public CityManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.CityRepository.GetManyAsyncWithInclude("Region"));
        }

        public async Task<IActionResult> Create()
        {
            var cityviewmodel = new CityRegionViewModel();
            cityviewmodel.City = new City();
            cityviewmodel.Regions = await _context.RegionRepository.GetAllAsync();
            return View(cityviewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(City city, int RegionId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    city.RegionId = RegionId;
                    _context.CityRepository.Insert(city);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CityManagment",
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
                _context.CityRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CityManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

    }
}
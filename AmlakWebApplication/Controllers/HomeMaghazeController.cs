using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.Home;

namespace AmlakWebApplication.Controllers
{
    public class HomeMaghazeController : Controller
    {
        IUnitofWork _context;

        public HomeMaghazeController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.MaghazeRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var maghaze = new MaghazeFacility();
            maghaze.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            maghaze.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            maghaze.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            maghaze.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            maghaze.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            maghaze.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            maghaze.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            maghaze.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            ViewData["Id"] = homeid;
            return View(maghaze);
        }

        public async Task<IActionResult> Update(int id)
        {
            var maghaze = new MaghazeFacility();
            maghaze.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            maghaze.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            maghaze.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            maghaze.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            maghaze.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            maghaze.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            maghaze.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            maghaze.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            maghaze.Maghaze = _context.MaghazeRepository.GetById(id);
            return View(maghaze);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Maghaze maghaze, int HomeId,string[] homemoshakhase,string[] homestatus,string[] homeemtiaz,string[] homewc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    maghaze.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    maghaze.Homevaziatemelk = string.Join(" , ", homestatus);
                    maghaze.Homewc = string.Join(" , ", homewc);
                    maghaze.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    maghaze.HomeId = HomeId;
                    _context.MaghazeRepository.Insert(maghaze);
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
                    LogController = "HomeMaghazeManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Maghaze maghaze, string[] homemoshakhase, string[] homestatus, string[] homeemtiaz, string[] homewc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    maghaze.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    maghaze.Homevaziatemelk = string.Join(" , ", homestatus);
                    maghaze.Homewc = string.Join(" , ", homewc);
                    maghaze.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.MaghazeRepository.Update(maghaze);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = maghaze.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeMaghazeManagment",
                    LogText = ex.ToString(),
                    LogView = "UpdateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.MaghazeRepository.Delete(id);
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
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
    public class HomeKolangiController : Controller
    {
        IUnitofWork _context;

        public HomeKolangiController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeKolangiRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var Kolangi = new KolangiFacility();
            Kolangi.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Kolangi.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Kolangi.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Kolangi.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            Kolangi.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();

            ViewData["Id"] = homeid;
            return View(Kolangi);
        }

        public async Task<IActionResult> Update(int id)
        {
            var Kolangi = new KolangiFacility();
            Kolangi.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Kolangi.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Kolangi.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Kolangi.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            Kolangi.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            Kolangi.Kolangi = _context.HomeKolangiRepository.GetById(id);
            return View(Kolangi);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Kolangi kolangi, int HomeId, string[] homestatus, string[] homemoshakhase, string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    kolangi.Homevaziate = string.Join(" , ", homestatus);
                    kolangi.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    kolangi.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    kolangi.HomeId = HomeId;
                    _context.HomeKolangiRepository.Insert(kolangi);
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
                    LogController = "HomeKolangiManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Kolangi kolangi, string[] homestatus, string[] homemoshakhase, string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    kolangi.Homevaziate = string.Join(" , ", homestatus);
                    kolangi.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    kolangi.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.HomeKolangiRepository.Update(kolangi);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = kolangi.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeKolangiManagment",
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
                _context.HomeKolangiRepository.Delete(id);
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
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
    public class HomeMostaghelatController : Controller
    {
        IUnitofWork _context;

        public HomeMostaghelatController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.MoshtghelatRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var mostaghelat = new MostaghelatFacility();
            mostaghelat.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            mostaghelat.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            mostaghelat.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            mostaghelat.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            mostaghelat.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            mostaghelat.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            mostaghelat.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            mostaghelat.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            mostaghelat.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            mostaghelat.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            mostaghelat.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            mostaghelat.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            mostaghelat.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            mostaghelat.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            mostaghelat.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            mostaghelat.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            mostaghelat.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            ViewData["Id"] = homeid;
            return View(mostaghelat);
        }

        public async Task<IActionResult> Update(int id)
        {
            var mostaghelat = new MostaghelatFacility();
            mostaghelat.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            mostaghelat.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            mostaghelat.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            mostaghelat.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            mostaghelat.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            mostaghelat.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            mostaghelat.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            mostaghelat.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            mostaghelat.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            mostaghelat.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            mostaghelat.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            mostaghelat.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            mostaghelat.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            mostaghelat.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            mostaghelat.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            mostaghelat.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            mostaghelat.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            mostaghelat.Mostaghelat = _context.MoshtghelatRepository.GetById(id);
            return View(mostaghelat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Moshtghelat mostaghelat, int HomeId,string[] homemoshakhase,string[] homemoshaat,string[] homekitchen,string[] homewc,string[] homestatus,string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    mostaghelat.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    mostaghelat.Homemoshaat = string.Join(" , ", homemoshaat);
                    mostaghelat.Homewc = string.Join(" , ", homewc);
                    mostaghelat.Homekitchen = string.Join(" , ", homekitchen);
                    mostaghelat.Homevaziate = string.Join(" , ", homestatus);
                    mostaghelat.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    mostaghelat.HomeId = HomeId;
                    _context.MoshtghelatRepository.Insert(mostaghelat);
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
                    LogController = "HomeMostaghelatManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Moshtghelat mostaghelat, string[] homemoshakhase, string[] homemoshaat, string[] homekitchen, string[] homewc, string[] homestatus, string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    mostaghelat.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    mostaghelat.Homemoshaat = string.Join(" , ", homemoshaat);
                    mostaghelat.Homewc = string.Join(" , ", homewc);
                    mostaghelat.Homekitchen = string.Join(" , ", homekitchen);
                    mostaghelat.Homevaziate = string.Join(" , ", homestatus);
                    mostaghelat.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.MoshtghelatRepository.Update(mostaghelat);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = mostaghelat.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeMostaghelatManagment",
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
                _context.MoshtghelatRepository.Delete(id);
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
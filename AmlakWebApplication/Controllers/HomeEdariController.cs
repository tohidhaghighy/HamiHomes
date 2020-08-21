﻿using System;
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
    public class HomeEdariController : Controller
    {
        IUnitofWork _context;

        public HomeEdariController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeEdariRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var Edari = new EdariFacility();
            Edari.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Edari.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            Edari.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            Edari.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Edari.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Edari.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            Edari.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            Edari.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            Edari.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            Edari.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            Edari.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            Edari.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            ViewData["Id"] = homeid;
            return View(Edari);
        }


        public async Task<IActionResult> Update(int id)
        {
            var Edari = new EdariFacility();
            Edari.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Edari.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            Edari.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            Edari.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Edari.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Edari.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            Edari.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            Edari.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            Edari.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            Edari.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            Edari.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            Edari.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            Edari.Edari = _context.HomeEdariRepository.GetById(id);
            return View(Edari);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Edari edari, int HomeId,string[] homestatus,string[] homeemtiaz,string[] homewc)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    edari.Homevaziate = string.Join(" , ", homestatus);
                    edari.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    edari.Homewc = string.Join(" , ", homewc);
                    edari.HomeId = HomeId;
                    _context.HomeEdariRepository.Insert(edari);
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
                    LogController = "HomeEdariManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Edari edari, string[] homestatus, string[] homeemtiaz, string[] homewc)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    edari.Homevaziate = string.Join(" , ", homestatus);
                    edari.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    edari.Homewc = string.Join(" , ", homewc);
                    _context.HomeEdariRepository.Update(edari);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = edari.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeEdariManagment",
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
                _context.HomeEdariRepository.Delete(id);
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
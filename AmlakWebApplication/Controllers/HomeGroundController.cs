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
    public class HomeGroundController : Controller
    {
        IUnitofWork _context;

        public HomeGroundController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ZaminRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var Ground = new ZaminFacility();
            Ground.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Ground.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Ground.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Ground.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            ViewData["Id"] = homeid;
            return View(Ground);
        }

        public async Task<IActionResult> Update(int id)
        {
            var Ground = new ZaminFacility();
            Ground.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            Ground.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            Ground.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            Ground.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            Ground.Zamin = _context.ZaminRepository.GetById(id);
            return View(Ground);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Zamin zamin, int HomeId,string[] homestatus ,string[] homeemtiaz)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    zamin.Homevaziate = string.Join(" , ", homestatus);
                    zamin.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    zamin.HomeId = HomeId;
                    _context.ZaminRepository.Insert(zamin);
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
                    LogController = "HomeZaminManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Zamin zamin, string[] homestatus, string[] homeemtiaz)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    zamin.Homevaziate = string.Join(" , ", homestatus);
                    zamin.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.ZaminRepository.Update(zamin);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = zamin.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeZaminManagment",
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
                _context.ZaminRepository.Delete(id);
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
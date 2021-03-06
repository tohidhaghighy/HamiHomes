﻿using System;
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
    public class HomeMostaghelatController : Controller
    {
        IUnitofWork _context;

        public HomeMostaghelatController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == false && a.Home.Hometype == 7).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> ShowMostaghelat()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && a.Home.Hometype == 7 && (a.TypContract == DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var mostaghelat = new MostaghelatFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            mostaghelat.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(mostaghelat);
        }

        public async Task<IActionResult> Update(int homeid, int hometype, int contracttype)
        {
            var mostaghelat = new MostaghelatFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            mostaghelat.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;

            var mostaghelatone = await _context.MoshtghelatRepository.GetManyAsync(a => a.HomeId == homeid);
            if (mostaghelatone != null)
            {
                mostaghelat.Mostaghelat = mostaghelatone.FirstOrDefault();
                return View(mostaghelat);
            }
            return RedirectToAction("Create", new { homeid = homeid, hometype = hometype, contracttype = contracttype });
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
        public async Task<IActionResult> UpdateItem(Moshtghelat mostaghelat,int Id,int HomeId, string[] homemoshakhase, string[] homemoshaat, string[] homekitchen, string[] homewc, string[] homestatus, string[] homeemtiaz)
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
                    mostaghelat.Id = Id;
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
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
    public class HomeVilaManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeVilaManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.VilaRepository.GetManyAsyncWithInclude("Home"));
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var villa = new VilaFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            villa.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(villa);
        }

        public async Task<IActionResult> Update(int id)
        {
            var villa = new VilaFacility();
            villa.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            villa.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync(); villa.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            villa.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            villa.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            villa.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            villa.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            villa.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            villa.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            villa.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            villa.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            villa.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            villa.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            villa.Vila = _context.VilaRepository.GetById(id);
            return View(villa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Vila vila, int HomeId,string[] homemoshakhase,string[] homemoshaat,string[] homekitchen,string[] homewc,string[] homestatus,string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vila.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    vila.Homemoshaat = string.Join(" , ", homemoshaat);
                    vila.Homewc = string.Join(" , ", homewc);
                    vila.Homekitchen = string.Join(" , ", homekitchen);
                    vila.Homevaziate = string.Join(" , ", homestatus);
                    vila.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    vila.HomeId = HomeId;
                    _context.VilaRepository.Insert(vila);
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
                    LogController = "HomevilaManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Vila vila, string[] homemoshakhase, string[] homemoshaat, string[] homekitchen, string[] homewc, string[] homestatus, string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vila.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    vila.Homemoshaat = string.Join(" , ", homemoshaat);
                    vila.Homewc = string.Join(" , ", homewc);
                    vila.Homekitchen = string.Join(" , ", homekitchen);
                    vila.Homevaziate = string.Join(" , ", homestatus);
                    vila.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.VilaRepository.Update(vila);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = vila.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomevilaManagment",
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
                _context.VilaRepository.Delete(id);
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
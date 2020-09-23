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
    public class HomeGroundController : Controller
    {
        IUnitofWork _context;

        public HomeGroundController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == false && a.Home.Hometype == 3).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> ShowGrounds()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && a.Home.Hometype == 3 && (a.TypContract == DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var Ground = new ZaminFacility();
            var typehomeid = (TypeHome)contracttype;
            var contracttypeid = (MelkType)hometype;
            Ground.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            ViewData["Id"] = homeid;
            return View(Ground);
        }

        public async Task<IActionResult> Update(int homeid, int hometype, int contracttype)
        {
            var Ground = new ZaminFacility();
            var typehomeid = (TypeHome)contracttype;
            var contracttypeid = (MelkType)hometype;
            Ground.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            ViewData["Id"] = homeid;
            var zaminone = await _context.ZaminRepository.GetManyAsync(a => a.HomeId == homeid);
            if (zaminone != null)
            {
                Ground.Zamin = zaminone.FirstOrDefault();
                return View(Ground);
            }
            return RedirectToAction("Create", new { homeid = homeid, hometype = hometype, contracttype = contracttype });
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
        public async Task<IActionResult> UpdateItem(Zamin zamin,int HomeId,int Id, string[] homestatus, string[] homeemtiaz)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    zamin.Homevaziate = string.Join(" , ", homestatus);
                    zamin.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    zamin.HomeId = HomeId;
                    zamin.Id = Id;
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
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
    public class HomeKolangiController : Controller
    {
        IUnitofWork _context;

        public HomeKolangiController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == false && a.Home.Hometype == 4).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> ShowKolangi()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && a.Home.Hometype == 4 && (a.TypContract == DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var Kolangi = new KolangiFacility();
            var contracttypeid = (TypeHome)contracttype;
            var typehomeid = (MelkType)hometype;
            Kolangi.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);

            ViewData["Id"] = homeid;
            return View(Kolangi);
        }

        public async Task<IActionResult> Update(int homeid, int hometype, int contracttype)
        {
            var Kolangi = new KolangiFacility();
            var contracttypeid = (TypeHome)contracttype;
            var typehomeid = (MelkType)hometype;
            Kolangi.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);

            ViewData["Id"] = homeid;
            var kolangione = await _context.HomeKolangiRepository.GetManyAsync(a => a.HomeId == homeid);
            if (kolangione != null)
            {
                Kolangi.Kolangi = kolangione.FirstOrDefault();
                return View(Kolangi);
            }
            return RedirectToAction("Create", new { homeid = homeid, hometype = hometype, contracttype = contracttype });
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
        public async Task<IActionResult> UpdateItem(Kolangi kolangi,int Id,int HomeId, string[] homestatus, string[] homemoshakhase, string[] homeemtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    kolangi.Homevaziate = string.Join(" , ", homestatus);
                    kolangi.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    kolangi.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    kolangi.HomeId = HomeId;
                    kolangi.Id = Id;
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
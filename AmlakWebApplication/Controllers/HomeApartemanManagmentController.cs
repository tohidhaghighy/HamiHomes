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
    public class HomeApartemanManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeApartemanManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeApartemanRepository.GetManyAsyncWithInclude("Home"));
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var aparteman = new ApartemanFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            aparteman.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(aparteman);
        }

        public async Task<IActionResult> Update(int id)
        {
            var aparteman = new ApartemanFacility();
            aparteman.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            aparteman.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            aparteman.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            aparteman.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            aparteman.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            aparteman.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            aparteman.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            aparteman.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            aparteman.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            aparteman.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            aparteman.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            aparteman.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            aparteman.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            aparteman.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            aparteman.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            aparteman.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            aparteman.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            aparteman.Aparteman = _context.HomeApartemanRepository.GetById(id);
            return View(aparteman);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Aparteman aparteman, int HomeId,string[] Homemoshakhase,string[] Homemoshaat,string[] Homekitchen,string[] Homewc,string[] Homevaziate,string[] HomeEmtiaz)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    aparteman.Homemoshakhase= string.Join(" , ", Homemoshakhase);
                    aparteman.Homemoshaat = string.Join(" , ", Homemoshaat);
                    aparteman.Homekitchen = string.Join(" , ", Homekitchen);
                    aparteman.Homevaziate = string.Join(" , ", Homevaziate);
                    aparteman.HomeEmtiaz = string.Join(" , ", HomeEmtiaz);
                    aparteman.Homewc = string.Join(" , ", Homewc);
                    aparteman.HomeId = HomeId;
                    _context.HomeApartemanRepository.Insert(aparteman);
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
                    LogController = "HomeApartemanManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Aparteman aparteman, string[] Homemoshakhase, string[] Homemoshaat, string[] Homekitchen, string[] Homewc, string[] Homevaziate, string[] HomeEmtiaz)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    aparteman.Homemoshakhase = string.Join(" , ", Homemoshakhase);
                    aparteman.Homemoshaat = string.Join(" , ", Homemoshaat);
                    aparteman.Homekitchen = string.Join(" , ", Homekitchen);
                    aparteman.Homevaziate = string.Join(" , ", Homevaziate);
                    aparteman.HomeEmtiaz = string.Join(" , ", HomeEmtiaz);
                    _context.HomeApartemanRepository.Update(aparteman);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = aparteman.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeApartemanManagment",
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
                _context.HomeApartemanRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeApartemanManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }
    }
}
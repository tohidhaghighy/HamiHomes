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
    public class HomeEdariController : Controller
    {
        IUnitofWork _context;

        public HomeEdariController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == false && a.Home.Hometype == 5).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> ShowEdaries()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && a.Home.Hometype == 5 && (a.TypContract == DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var Edari = new EdariFacility();
            var contracttypeid = (TypeHome)contracttype;
            var typehomeid = (MelkType)hometype;
            Edari.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(Edari);
        }


        public async Task<IActionResult> Update(int homeid, int hometype, int contracttype)
        {
            var Edari = new EdariFacility();
            var contracttypeid = (TypeHome)contracttype;
            var typehomeid = (MelkType)hometype;
            Edari.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            var edarione = await _context.HomeEdariRepository.GetManyAsync(a => a.HomeId == homeid);
            if (edarione != null)
            {
                Edari.Edari = edarione.FirstOrDefault();
                return View(Edari);
            }
            return RedirectToAction("Create", new { homeid = homeid, hometype = hometype, contracttype = contracttype });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Edari edari, int HomeId,string[] homestatus,string[] homeemtiaz,string[] homewc, string[] tasisat, string[] parking)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    edari.Homevaziate = string.Join(" , ", homestatus);
                    edari.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    edari.Homewc = string.Join(" , ", homewc);
                    edari.Homeparking = string.Join(" , ", parking);
                    edari.Hometasisat = string.Join(" , ", tasisat);
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
        public async Task<IActionResult> UpdateItem(Edari edari,int HomeId,int Id, string[] homestatus, string[] homeemtiaz, string[] homewc,string[] HomeFacility,string[] tasisat,string[] parking)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    edari.Homevaziate = string.Join(" , ", homestatus);
                    edari.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    edari.Homewc = string.Join(" , ", homewc);
                    edari.Homeparking= string.Join(" , ", parking);
                    edari.Hometasisat = string.Join(" , ", tasisat);
                    edari.HomeId = HomeId;
                    edari.Id = Id;
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
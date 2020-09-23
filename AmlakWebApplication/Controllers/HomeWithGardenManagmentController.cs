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
    public class HomeWithGardenManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeWithGardenManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == false && a.Home.Hometype == 2).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> ShowHomeWithGarden()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && a.Home.Hometype == 2 && (a.TypContract == DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var homewithgarden = new HomeWithGardenFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            homewithgarden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(homewithgarden);
        }


        public async Task<IActionResult> Update(int homeid, int hometype, int contracttype)
        {
            var homewithgarden = new HomeWithGardenFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            homewithgarden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;

            var homewithgardenone = await _context.HomeWithGardenRepository.GetManyAsync(a => a.HomeId == homeid);
            if (homewithgardenone != null)
            {
                homewithgarden.HomewithGarden = homewithgardenone.FirstOrDefault();
                return View(homewithgarden);
            }
            return RedirectToAction("Create", new { homeid = homeid, hometype = hometype, contracttype = contracttype });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(HomewithGarden HomewithGarden, int HomeId,string[] AmlakNema,string[] moshakhase,string[] AmlakParking,string[] kitchen,string[] homewc,string[] vaziat,string[] HomeFacility,string[] emtiaz,string[] tasisat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HomewithGarden.Homenema = string.Join(" , ", AmlakNema);
                    HomewithGarden.Homemoshakhase = string.Join(" , ", moshakhase);
                    HomewithGarden.Homeparking = string.Join(" , ", AmlakParking);
                    HomewithGarden.Homekitchen = string.Join(" , ", kitchen);
                    HomewithGarden.Homewc = string.Join(" , ", homewc);
                    HomewithGarden.Homevaziate = string.Join(" , ", vaziat);
                    HomewithGarden.HomeEmtiaz= string.Join(" , ", emtiaz);
                    HomewithGarden.Hometasisat= string.Join(" , ", tasisat);
                    HomewithGarden.HomeId = HomeId;
                    _context.HomeWithGardenRepository.Insert(HomewithGarden);
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
                    LogController = "HomeWithGardenManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(HomewithGarden HomewithGarden , int Id, int HomeId, string[] AmlakNema, string[] moshakhase, string[] AmlakParking, string[] kitchen, string[] homewc, string[] vaziat, string[] HomeFacility, string[] emtiaz, string[] tasisat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HomewithGarden.Homenema = string.Join(" , ", AmlakNema);
                    HomewithGarden.Homemoshakhase = string.Join(" , ", moshakhase);
                    HomewithGarden.Homeparking = string.Join(" , ", AmlakParking);
                    HomewithGarden.Homekitchen = string.Join(" , ", kitchen);
                    HomewithGarden.Homewc = string.Join(" , ", homewc);
                    HomewithGarden.Homevaziate = string.Join(" , ", vaziat);
                    HomewithGarden.HomeEmtiaz = string.Join(" , ", emtiaz);
                    HomewithGarden.Hometasisat = string.Join(" , ", tasisat);
                    HomewithGarden.HomeId = HomeId;
                    HomewithGarden.Id = Id;
                    _context.HomeWithGardenRepository.Update(HomewithGarden);
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
                    LogController = "HomeWithGardenManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
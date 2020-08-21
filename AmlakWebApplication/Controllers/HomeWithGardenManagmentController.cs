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
    public class HomeWithGardenManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeWithGardenManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeWithGardenRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int homeid)
        {
            var homewithgarden = new HomeWithGardenFacility();
            homewithgarden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            homewithgarden.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            homewithgarden.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            homewithgarden.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            homewithgarden.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            homewithgarden.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            homewithgarden.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            homewithgarden.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            homewithgarden.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            homewithgarden.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            homewithgarden.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            homewithgarden.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            homewithgarden.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            homewithgarden.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            homewithgarden.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            homewithgarden.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            homewithgarden.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            ViewData["Id"] = homeid;
            return View(homewithgarden);
        }


        public async Task<IActionResult> Update(int id)
        {
            var homewithgarden = new HomeWithGardenFacility();
            homewithgarden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            homewithgarden.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            homewithgarden.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetAllAsync();
            homewithgarden.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            homewithgarden.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            homewithgarden.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            homewithgarden.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            homewithgarden.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            homewithgarden.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            homewithgarden.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            homewithgarden.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            homewithgarden.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            homewithgarden.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetAllAsync();
            homewithgarden.AmlakSaghf = await _context.AmlakSaghfRepository.GetAllAsync();
            homewithgarden.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            homewithgarden.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            homewithgarden.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            homewithgarden.HomewithGarden = _context.HomeWithGardenRepository.GetById(id);
            return View(homewithgarden);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(HomewithGarden HomewithGarden, int HomeId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
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
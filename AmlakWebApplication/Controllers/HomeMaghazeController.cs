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
    public class HomeMaghazeController : Controller
    {
        IUnitofWork _context;

        public HomeMaghazeController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.MaghazeRepository.GetManyAsyncWithInclude("Home"));
        }

        public async Task<IActionResult> Create(int homeid, int hometype, int contracttype)
        {
            var maghaze = new MaghazeFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            maghaze.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(maghaze);
        }

        public async Task<IActionResult> Update(int id)
        {
            var maghaze = new MaghazeFacility();
            maghaze.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            maghaze.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            maghaze.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            maghaze.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            maghaze.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            maghaze.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            maghaze.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            maghaze.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            maghaze.Maghaze = _context.MaghazeRepository.GetById(id);
            return View(maghaze);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(Maghaze maghaze, int HomeId,string[] homemoshakhase,string[] homestatus,string[] homeemtiaz,string[] homewc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    maghaze.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    maghaze.Homevaziatemelk = string.Join(" , ", homestatus);
                    maghaze.Homewc = string.Join(" , ", homewc);
                    maghaze.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    maghaze.HomeId = HomeId;
                    _context.MaghazeRepository.Insert(maghaze);
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
                    LogController = "HomeMaghazeManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Maghaze maghaze, string[] homemoshakhase, string[] homestatus, string[] homeemtiaz, string[] homewc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    maghaze.Homemoshakhase = string.Join(" , ", homemoshakhase);
                    maghaze.Homevaziatemelk = string.Join(" , ", homestatus);
                    maghaze.Homewc = string.Join(" , ", homewc);
                    maghaze.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    _context.MaghazeRepository.Update(maghaze);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = maghaze.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeMaghazeManagment",
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
                _context.MaghazeRepository.Delete(id);
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
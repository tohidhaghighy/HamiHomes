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
    public class HomeAnbarManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeAnbarManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeAnbarRepository.GetManyAsyncWithInclude("Home"));
        }

        public async Task<IActionResult> Create(int homeid,int hometype,int contracttype)
        {
            var anbar = new AnbarFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            anbar.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a=>a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            ViewData["Id"] = homeid;
            return View(anbar);
        }


        public async Task<IActionResult> Update(int id)
        {
            var anbar = new AnbarFacility();
            anbar.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            anbar.Anbar = _context.HomeAnbarRepository.GetById(id);
            anbar.Selectedlist = anbar.Anbar.HomeEmtiaz.Split(new char[] { ',' });
            return View(anbar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFacilityItem(AnbarFacility facility, int HomeId, string[] emtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string emtiazlist = string.Join(" , ", emtiaz);
                    var anbar = new Anbar()
                    {
                        HomeId=HomeId,
                        MetrazhBena=facility.Anbar.MetrazhBena,
                        Metrazhzamin=facility.Anbar.Metrazhzamin,
                        NegahbaniName=facility.Anbar.NegahbaniName,
                        NegahbaniPhone=facility.Anbar.NegahbaniPhone,
                        HomeEmtiaz=emtiazlist
                    };
                    _context.HomeAnbarRepository.Insert(anbar);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = anbar.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeAnbarManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(AnbarFacility facility, int HomeId, string[] emtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string emtiazlist = string.Join(" , ", emtiaz);
                    var anbar = new Anbar()
                    {
                        HomeId = HomeId,
                        MetrazhBena = facility.Anbar.MetrazhBena,
                        Metrazhzamin = facility.Anbar.Metrazhzamin,
                        NegahbaniName = facility.Anbar.NegahbaniName,
                        NegahbaniPhone = facility.Anbar.NegahbaniPhone,
                        HomeEmtiaz = emtiazlist,
                        Id=facility.Anbar.Id
                    };
                    _context.HomeAnbarRepository.Update(anbar);
                    await _context.CommitAsync();
                    return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = facility.Anbar.HomeId });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeAnbarManagment",
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
                _context.HomeAnbarRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeAnbarManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        
    }
}
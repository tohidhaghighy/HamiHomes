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

namespace AmlakWebApplication.UI.Controllers
{
    public class CreateHomeTypeController : Controller
    {
        IUnitofWork _context;

        public CreateHomeTypeController(IUnitofWork repo)
        {
            this._context = repo;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnbarFacility(AnbarFacility facility, int HomeId, string[] emtiaz,int userid)
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
                        HomeEmtiaz = emtiazlist
                    };
                    _context.HomeAnbarRepository.Insert(anbar);
                    await _context.CommitAsync();
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = anbar.HomeId ,userid = userid});
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateApartemanFacility(Aparteman aparteman, int HomeId,int userid, string[] Homemoshakhase, string[] Homemoshaat, string[] Homekitchen, string[] Homewc, string[] Homevaziate, string[] HomeEmtiaz)
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
                    aparteman.Homewc = string.Join(" , ", Homewc);
                    aparteman.HomeId = HomeId;
                    _context.HomeApartemanRepository.Insert(aparteman);
                    await _context.CommitAsync();
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = aparteman.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEdariFacility(Edari edari, int HomeId, int userid, string[] homestatus, string[] homeemtiaz, string[] homewc)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    edari.Homevaziate = string.Join(" , ", homestatus);
                    edari.HomeEmtiaz = string.Join(" , ", homeemtiaz);
                    edari.Homewc = string.Join(" , ", homewc);
                    edari.HomeId = HomeId;
                    _context.HomeEdariRepository.Insert(edari);
                    await _context.CommitAsync();
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = edari.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGardenFacility(Garden garden, int HomeId,int userid, string[] emtiaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    garden.HomeEmtiaz = string.Join(" , ", emtiaz);
                    garden.HomeId = HomeId;
                    _context.HomeGardenRepository.Insert(garden);
                    await _context.CommitAsync();
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = garden.HomeId, userid = userid });
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeGardenManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateFacilityItem"
                });

            }
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateZaminFacility(Zamin zamin, int HomeId,int userid, string[] homestatus, string[] homeemtiaz)
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
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = zamin.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateKolangiFacility(Kolangi kolangi, int HomeId,int userid, string[] homestatus, string[] homemoshakhase, string[] homeemtiaz)
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
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = kolangi.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMaghazeFacility(Maghaze maghaze, int HomeId,int userid, string[] homemoshakhase, string[] homestatus, string[] homeemtiaz, string[] homewc)
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
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = maghaze.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMostaghelatFacility(Moshtghelat mostaghelat, int HomeId,int userid, string[] homemoshakhase, string[] homemoshaat, string[] homekitchen, string[] homewc, string[] homestatus, string[] homeemtiaz)
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
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = mostaghelat.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVillaFacility(Vila vila, int HomeId,int userid, string[] homemoshakhase, string[] homemoshaat, string[] homekitchen, string[] homewc, string[] homestatus, string[] homeemtiaz)
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
                    return RedirectToAction("Gallery", "AllHomeType", new { homeid = vila.HomeId, userid = userid });
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
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHomewithgardenFacility(HomewithGarden HomewithGarden, int HomeId,int userid, string[] Homemoshakhase, string[] Homemoshaat, string[] Homekitchen, string[] Homewc, string[] Homevaziate, string[] HomeEmtiaz)
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
            return RedirectToAction();
        }
    }
}
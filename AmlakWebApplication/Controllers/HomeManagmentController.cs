using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.Home;

namespace AmlakWebApplication.Controllers
{
    public class HomeManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeRepository.GetAllAsync());
        }

        public async Task<IActionResult> Search()
        {
            return View(await _context.HomeRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            var home = new HomeProperty();
            home.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            return View(home);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Home home,int typehome,string txtkuche, IFormFile homeImage, IFormFile pelanImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (homeImage != null)
                    {
                        var fileName = Guid.NewGuid() + homeImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await homeImage.CopyToAsync(stream);

                        }
                        home.Image = fileName;
                    }

                    if (pelanImage != null)
                    {
                        var fileName = Guid.NewGuid() + pelanImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await pelanImage.CopyToAsync(stream);

                        }
                        home.HomeMapImage = fileName;
                    }
                    if (txtkuche!=null)
                    {
                        home.Address += " " + txtkuche;
                    }

                    _context.HomeRepository.Insert(home);
                    await _context.CommitAsync();
                    return OpenUrl(typehome, home.Id);
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateFacility(int id)
        {
            ViewData["Id"] = id;
            var allinfo = new HomeFacilities();
            allinfo.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetAllAsync();
            allinfo.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetAllAsync();
            allinfo.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetAllAsync();
            allinfo.AmlakNema = await _context.AmlakNemaRepository.GetAllAsync();
            allinfo.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetAllAsync();
            allinfo.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync();
            allinfo.AmlakKafes = await _context.AmlakKafRepository.GetAllAsync();
            allinfo.AmlakKitchenes = await _context.AmlakKitchenRepository.GetAllAsync();
            allinfo.AmlakWC = await _context.AmlakWcRepository.GetAllAsync();
            allinfo.AmlakDivars = await _context.AmlakDivarRepository.GetAllAsync();
            allinfo.AmlakParking = await _context.AmlakParkingRepository.GetAllAsync();
            allinfo.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetAllAsync();
            allinfo.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetAllAsync();
            allinfo.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetAllAsync();
            return View(allinfo);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFacilityItem(HomeFacilities facility,int HomeId)
        {
            return RedirectToAction("Index", "HomeGalleryManagment", new { homeid = HomeId });
            try
            {
                if (ModelState.IsValid)
                {

                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomefacilityManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            var home = new HomeProperty();
            home.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            home.Home = _context.HomeRepository.GetById(id);
            return View(home);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Home home, int typehome, string txtkuche, IFormFile homeImage, IFormFile pelanImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (homeImage != null)
                    {
                        var fileName = Guid.NewGuid() + homeImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await homeImage.CopyToAsync(stream);

                        }
                        home.Image = fileName;
                    }

                    if (pelanImage != null)
                    {
                        var fileName = Guid.NewGuid() + pelanImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await pelanImage.CopyToAsync(stream);

                        }
                        home.HomeMapImage = fileName;
                    }

                    if (txtkuche != null)
                    {
                        home.Address += " " + txtkuche;
                    }

                    _context.HomeRepository.Update(home);
                    await _context.CommitAsync();
                    return OpenUrl(typehome, home.Id);
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult OpenUrl(int typename,int id)
        {
            if (typename==1)
            {
                return RedirectToAction(nameof(Create), "HomeApartemanManagment", new { homeid = id });
            }
            else if (typename==2)
            {
                return RedirectToAction(nameof(Create), "HomeWithGardenManagment", new { homeid = id });
            }
            else if (typename == 3)
            {
                return RedirectToAction(nameof(Create), "HomeGround", new { homeid = id });
            }
            else if (typename == 4)
            {
                return RedirectToAction(nameof(Create), "HomeKolangi", new { homeid = id });
            }
            else if (typename == 5)
            {
                return RedirectToAction(nameof(Create), "HomeEdari", new { homeid = id });
            }
            else if (typename == 6)
            {
                return RedirectToAction(nameof(Create), "HomeMaghaze", new { homeid = id });
            }
            else if (typename == 7)
            {
                return RedirectToAction(nameof(Create), "HomeMostaghelat", new { homeid = id });
            }
            else if (typename == 8)
            {
                return RedirectToAction(nameof(Create), "HomeAnbarManagment", new { homeid = id });
            }
            else if (typename == 9)
            {
                return RedirectToAction(nameof(Create), "HomeVilaManagment", new { homeid = id });
            }
            return RedirectToAction(nameof(Create), "HomeGardenManagment", new { homeid = id });
        }

    }
}
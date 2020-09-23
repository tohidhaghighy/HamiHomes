using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Hash;
using ViewModelLayer.AdvisorManagment;

namespace AmlakWebApplication.Controllers
{
    public class AdvisorManagmentController : Controller
    {
        IUnitofWork _context;

        public AdvisorManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.AdviserRepository.GetAllAsync());
        }

        public async Task<IActionResult> AdviserSelect(int contractid)
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                ViewData["contractid"] = contractid;
                findall.Add(oneadviserinfo);
            }
            
            return View(findall);
        }

        public async Task<PartialViewResult> Searchfast(string takhasos = "", string manategh = "")
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true && (a.RentTakhasos.Contains(takhasos) || a.BuyTakhasos.Contains(takhasos) || a.Manategh.Contains(manategh)));
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }

        public async Task<PartialViewResult> Searchsabeghe()
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }
            findall = findall.OrderByDescending(a => a.Adviser.ExperienceYear).ToList();

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }

        public async Task<PartialViewResult> Searchforosh()
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }
            findall = findall.OrderByDescending(a => a.BuyCount).ToList();

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }

        public async Task<PartialViewResult> Searchejare()
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }
            findall = findall.OrderByDescending(a => a.RentCount).ToList();

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }

        public async Task<PartialViewResult> Searchforokhteshode()
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }
            findall = findall.OrderByDescending(a => a.SellCount).ToList();

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }

        public async Task<PartialViewResult> Searchejaredadeshode()
        {
            var findall = new List<ViewModelLayer.Adviser.AdviserInfo>();
            var findadvisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            foreach (var item in findadvisers)
            {
                var oneadviserinfo = new ViewModelLayer.Adviser.AdviserInfo();
                oneadviserinfo.Adviser = item;
                var findhomes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == item.Id);
                //oneadviserinfo.BuildCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentCount = findhomes.Where(a => a.TypContract == TypeHome.build).Count();
                oneadviserinfo.BuyCount = findhomes.Where(a => a.TypContract == TypeHome.Buy).Count();
                oneadviserinfo.SellCount = findhomes.Where(a => a.TypContract == TypeHome.Selled).Count();
                oneadviserinfo.RentedCount = findhomes.Where(a => a.TypContract == TypeHome.Rented).Count();
                findall.Add(oneadviserinfo);
            }
            findall = findall.OrderByDescending(a => a.RentedCount).ToList();

            return PartialView("_ListAjaxSelectedAdviser", findall);
        }


        public async Task<IActionResult> Create()
        {
            var main = new MainAdvisor();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            main.Regions = await _context.RegionRepository.GetAllAsync();
            main.Cities = await _context.CityRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> AmlakList(int type,int id)
        {
            TypeHome hometype = (TypeHome)type; 
            var find = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == id && a.TypContract == hometype);
            return View(find);
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.AdviserRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Adviser adviser, IFormFile Image, IFormFile BackgroundImage,string[] mahale,int city)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Image != null)
                    {
                        var fileName = Guid.NewGuid() + Image.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Image.CopyToAsync(stream);

                        }
                        adviser.Image = ImageUrl.url + fileName;
                    }

                    if (BackgroundImage != null)
                    {
                        var fileName = Guid.NewGuid() + BackgroundImage.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await BackgroundImage.CopyToAsync(stream);

                        }
                        adviser.BackgroundImage = ImageUrl.url + fileName;
                    }
                    adviser.Manategh= string.Join(" , ", mahale);
                    adviser.CityId = city;
                    adviser.Password = adviser.Password.GetHashPassword();
                    _context.AdviserRepository.Insert(adviser);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<Boolean> ChangeCheck(int id)
        {
            try
            {
                await _context.AdviserRepository.ChangeCheck(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AdvisorManagment",
                    LogText = ex.ToString(),
                    LogView = "ChangeCheck"
                });
            }
            return false;
        }

    }
}
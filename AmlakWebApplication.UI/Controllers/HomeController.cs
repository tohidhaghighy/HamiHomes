using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmlakWebApplication.UI.Models;
using DataLayer.Infrastracture;
using ViewModelLayer.UI;
using DomainLayer;

namespace AmlakWebApplication.UI.Controllers
{
    public class HomeController : Controller
    {
        IUnitofWork _context;

        public HomeController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index()
        {
            var main = new MainPage();
            main.CostSetting = await _context.CostSettingRepository.GetAllAsync();
            main.MetrazSetting = await _context.MetrazSettingRepository.GetAllAsync();
            main.EjareSetting = await _context.EjareSettingRepository.GetAllAsync();
            main.VadieSetting = await _context.VadieSettingRepository.GetAllAsync();
            main.CostSetting =  main.CostSetting.OrderBy(a=>a.CostChance).ToList();
            main.MetrazSetting = main.MetrazSetting.OrderBy(a => a.MetrazChance).ToList();
            main.EjareSetting = main.EjareSetting.OrderBy(a => a.CostChance).ToList();
            main.VadieSetting = main.VadieSetting.OrderBy(a => a.CostChance).ToList();
            return View(main);
        }

        public IActionResult Search()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<JsonResult> GetMetrazbana()
        {
            var metraz = new MetrazList();
            var findmetr = await _context.MetrazSettingRepository.GetManyAsync(a=>a.TypeMetraz==1);
            foreach (var item in findmetr)
            {
                metraz.buyminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"buyminmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.buymaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"buymaxmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.rentminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"rentminmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.rentmaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"rentmaxmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
            }
            return Json(metraz);
        }

        [HttpPost]
        public async Task<JsonResult> GetMetrazzamin()
        {
            var metraz = new MetrazList();
            var findmetr = await _context.MetrazSettingRepository.GetManyAsync(a => a.TypeMetraz == 2);
            foreach (var item in findmetr)
            {
                metraz.buyminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"buyminmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.buymaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"buymaxmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.rentminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"rentminmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
                metraz.rentmaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"rentmaxmetr(" + item.Id + ",'" + item.Metraz + "');\">" + item.Metraz + "</a><br />";
            }
            return Json(metraz);
        }
    }
}

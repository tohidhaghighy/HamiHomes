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
using ViewModelLayer.Detail;

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

        public async Task<IActionResult> Detail(int homeid,int contractid,string hometype)
        {
            var allinfo = new Detailpage();
            allinfo.home =  _context.HomeRepository.GetById(homeid);
            var find = _context.ContractRepository.GetByIdwithinclude("Adviser");
            allinfo.contract = find.FirstOrDefault(a => a.Id == contractid);
            allinfo.gallery =await _context.HomeGalleryRepository.GetManyAsync(a=>a.HomeId==homeid);
            if (allinfo.home.Hometype==1)
            {
                allinfo.aparteman = _context.HomeApartemanRepository.GetMany(a=>a.HomeId==homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 2)
            {
                allinfo.homewithgarden = _context.HomeWithGardenRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 3)
            {
                allinfo.zamin = _context.ZaminRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 4)
            {
                allinfo.kolangi = _context.HomeKolangiRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 5)
            {
                allinfo.edari = _context.HomeEdariRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 6)
            {
                allinfo.maghaze = _context.MaghazeRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 7)
            {
                allinfo.moshtghelat = _context.MoshtghelatRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 8)
            {
                allinfo.anbar = _context.HomeAnbarRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 9)
            {
                allinfo.garden = _context.HomeGardenRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            else if (allinfo.home.Hometype == 10)
            {
                allinfo.vila = _context.VilaRepository.GetMany(a => a.HomeId == homeid).FirstOrDefault();
            }
            var findallcontract = await _context.ContractRepository.GetManyAsyncWithInclude("Home");
            if (findallcontract.Count()>4)
            {
                findallcontract = findallcontract.Take(4).ToList();
            }
            ViewData["hometype"] = hometype;
            allinfo.Samehome = findallcontract;
            return View(allinfo);
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


        [HttpPost]
        public async Task<JsonResult> GetMetrazbanapage2()
        {
            var metraz = new MetrazList();
            var findmetr = await _context.MetrazSettingRepository.GetManyAsync(a => a.TypeMetraz == 1);
            foreach (var item in findmetr)
            {
                metraz.buyminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showminmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
                metraz.buymaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showmaxmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
                metraz.rentminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showminmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
                metraz.rentmaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showmaxmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
            }
            return Json(metraz);
        }

        [HttpPost]
        public async Task<JsonResult> GetMetrazzaminoage2()
        {
            var metraz = new MetrazList();
            var findmetr = await _context.MetrazSettingRepository.GetManyAsync(a => a.TypeMetraz == 2);
            foreach (var item in findmetr)
            {
                metraz.buyminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showminmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
                metraz.buymaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showmaxmetraz('" + item.Metraz + "'," + item.Id + ",);\">" + item.Metraz + "</a><br />";
                metraz.rentminmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showminmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
                metraz.rentmaxmetraz += "<a class='btn select-btn dropdown-item' style='font-size:15px;font-family:sahel;' onclick=\"showmaxmetraz('" + item.Metraz + "'," + item.Id + ");\">" + item.Metraz + "</a><br />";
            }
            return Json(metraz);
        }

        [HttpPost]
        public async Task<JsonResult> Getdatalist()
        {
            string s= "";
            var find = await _context.MahalleRepository.GetAllAsync();
            foreach (var item in find)
            {
                s += "<option class='text-center' value=" + item.Name + " > " + item.Name + " </option>";
            }
            return Json(s);
        }
    }
}

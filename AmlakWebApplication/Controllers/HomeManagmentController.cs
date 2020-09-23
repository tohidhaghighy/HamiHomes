using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Random;
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
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home","Adviser", a=>a.Home.IsShow==false).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> AllShowMelk()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && (a.TypContract==DomainLayer.Enums.TypeHome.Buy || a.TypContract == DomainLayer.Enums.TypeHome.Rent || a.TypContract == DomainLayer.Enums.TypeHome.build)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> AllFinishMelk()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.IsShow == true && (a.TypContract == DomainLayer.Enums.TypeHome.Rented || a.TypContract == DomainLayer.Enums.TypeHome.Selled || a.TypContract == DomainLayer.Enums.TypeHome.builded)).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> AllShowVagozarMelk()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Contracts = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == DomainLayer.Enums.TypeHome.SellWithOther || a.TypContract == DomainLayer.Enums.TypeHome.Cancel).ToList();
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            return View(main);
        }
        

        public async Task<IActionResult> Search()
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            main.Homes = await _context.HomeRepository.GetManyAsync(a => a.IsShow == false);
            main.Mahalles = await _context.MahalleRepository.GetAllAsync();
            main.MetrazSetting = await _context.MetrazSettingRepository.GetAllAsync();
            main.EjareSetting = await _context.EjareSettingRepository.GetAllAsync();
            main.CostSetting = await _context.CostSettingRepository.GetAllAsync();
            return View(main);
        }

        public async Task<IActionResult> Create()
        {
            var home = new HomeProperty();
            home.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            home.Cities = home.Cities.OrderBy(a => a.Name).ToList();
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            home.Mahalles = home.Mahalles.OrderBy(a => a.Name).ToList();
            home.Regions = await _context.RegionRepository.GetAllAsync();
            return View(home);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Home home,int typehome,string txtkuche, IFormFile homeImage, IFormFile pelanImage,string conty)
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
                        home.Image = ImageUrl.url + fileName;
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
                        home.HomeMapImage = ImageUrl.url + fileName;
                    }
                    if (txtkuche!=null)
                    {
                        home.Address += " کوچه " + txtkuche;
                    }
                    if (conty!=null)
                    {
                        var findcity = await _context.CityRepository.GetAsync(a => a.Name.Contains(conty));
                        var findhomesfinal = await _context.HomeRepository.GetManyAsync(a=>a.Address.Contains(conty));
                        var homecounts = findhomesfinal.OrderByDescending(a=>a.Id).FirstOrDefault();
                        
                        if (findcity!=null)
                        {
                            if (homecounts == null)
                            {
                                home.Code = RandomNumber.MakeKey(findcity.Code, 0);
                            }
                            else
                            {
                                home.Code = RandomNumber.MakeKey(findcity.Code, homecounts.Id);
                            }
                            
                            home.Hometype = typehome;
                            home.AdvisorId = 0;
                            home.Usertype = DomainLayer.Enums.UserType.Admin;
                            _context.HomeRepository.Insert(home);
                            await _context.CommitAsync();
                        }
                    }
                    
                    
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
            home.Cities = home.Cities.OrderBy(a => a.Name).ToList();
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            home.Mahalles = home.Mahalles.OrderBy(a => a.Name).ToList();
            home.Regions = await _context.RegionRepository.GetAllAsync();
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
                        home.Image = ImageUrl.url + fileName;
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
                        home.HomeMapImage = ImageUrl.url + fileName;
                    }

                    if (txtkuche != null)
                    {
                        home.Address += " کوچه  " + txtkuche;
                    }
                    home.Hometype = typehome;
                    _context.HomeRepository.Update(home);
                    await _context.CommitAsync();
                    return await OpenUrlUpdate(typehome, home.Id);
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
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id ,hometype=1,text="آپارتمان"});
            }
            else if (typename==2)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 2, text = "خانه حیاط دار" });
            }
            else if (typename == 3)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 3, text = "زمین" });
            }
            else if (typename == 4)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 4, text = "کلنگی" });
            }
            else if (typename == 5)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 5, text = "اداری" });
            }
            else if (typename == 6)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 6, text = "مغازه" });
            }
            else if (typename == 7)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 7, text = "مستقلات" });
            }
            else if (typename == 8)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 8, text = "انبار" });
            }
            else if (typename == 9)
            {
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 9, text = "ویلا" });
            }
            return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = id, hometype = 10, text = "باغ و باغچه" });
        }


        public async Task<IActionResult> OpenUrlUpdate(int typename, int id)
        {
            var contract = _context.ContractRepository.GetAllWithWhereandInclude("Home",a => a.HomeId == id).FirstOrDefault();
            if (contract==null)
            {
                return RedirectToAction("Index");
            }
            if (typename == 1)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid=contract.Id , homeid = id, hometype = 1, text = "آپارتمان"});
            }
            else if (typename == 2)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 2, text = "خانه حیاط دار" });
            }
            else if (typename == 3)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 3, text = "زمین" });
            }
            else if (typename == 4)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 4, text = "کلنگی" });
            }
            else if (typename == 5)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 5, text = "اداری" });
            }
            else if (typename == 6)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 6, text = "مغازه" });
            }
            else if (typename == 7)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 7, text = "مستقلات" });
            }
            else if (typename == 8)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 8, text = "انبار" });
            }
            else if (typename == 9)
            {
                return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 9, text = "ویلا" });
            }
            return RedirectToAction("Update", "ContractManagment", new { contractid = contract.Id, homeid = id, hometype = 10, text = "باغ و باغچه" });
        }


        [HttpPost]
        public async Task<Boolean> CheckChange(int id)
        {
            try
            {
                await _context.HomeRepository.ChangeCheck(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        public async Task<PartialViewResult> GetHomePartial(string code="", string mahale="",int type=0)
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            if (type==0)
            {
                main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.Code.Contains(code) || a.Home.Address.Contains(mahale)).ToList();
            }
            else
            {
                main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => (a.Home.Code.Contains(code) || a.Home.Address.Contains(mahale)) && a.Home.Hometype==type).ToList();
            }
            
            return PartialView("_ListAjax", main.Contracts);
        }

        public async Task<PartialViewResult> SearchmelkPartial(int melk = 0, int type = 0)
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            var contracttypeid = (TypeHome)type;
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.TypContract== contracttypeid && a.Home.Hometype==melk).ToList();
            return PartialView("_AllinfoListAjax", main.Contracts);
        }

        public async Task<PartialViewResult> SearchmelkSelledPartial(int melk = 0, int type = 0)
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            var contracttypeid = (TypeHome)type;
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.TypContract == contracttypeid && a.Home.Hometype == melk).ToList();
            return PartialView("SearchmelkSelledPartial", main.Contracts);
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.HomeRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        public async Task<string> GetValues()
        {
            string num = "";
            var find = await _context.ContractRepository.GetManyAsyncWithInclude("Home");
            for (int i = 1; i <= 10; i++)
            {
                num += find.Where(a => a.Home.Hometype == i && a.Home.IsShow == false).Count()+",";
            }
            return num;
        }


        public async Task<PartialViewResult> SearchmelkVagozarPartial(int melk = 0, int type = 0)
        {
            var main = new ViewModelLayer.HomeManagment.MainSearch();
            var contracttypeid = (TypeHome)type;
            main.Contracts = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.TypContract == contracttypeid && a.Home.Hometype == melk).ToList();
            return PartialView("_AllinfovagozarListAjax", main.Contracts);
        }
        
    }
}
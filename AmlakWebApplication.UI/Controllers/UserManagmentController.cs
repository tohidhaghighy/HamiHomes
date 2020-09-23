using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.UI.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Contract;
using DomainLayer.Enums;
using DomainLayer.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Random;
using ViewModelLayer.Home;

namespace AmlakWebApplication.UI.Controllers
{
    public class UserManagmentController : Controller
    {
        IUnitofWork _context;

        public UserManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public IActionResult Index(int userid)
        {
            var main = new ViewModelLayer.User.UserMain();
            main.User = _context.UserRepository.GetById(userid);
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.Home.AdvisorId == userid && a.Home.Usertype==DomainLayer.Enums.UserType.User).ToList();
            return View(main);
        }

        public IActionResult Contracts(int userid)
        {
            var main = new ViewModelLayer.User.UserMain();
            main.User = _context.UserRepository.GetById(userid);
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.Home.AdvisorId == userid && a.Home.Usertype == DomainLayer.Enums.UserType.User).ToList();
            return View(main);
        }


        public async Task<IActionResult> CreateContract(int userid)
        {
            var main = new ViewModelLayer.User.UserMain();
            main.User = _context.UserRepository.GetById(userid);
            string username = Request.Cookies["userusername"];
            string password = Request.Cookies["userpassword"];
            if (username != "" && password != "")
            {
                if (main.User.Active == false)
                {
                    return RedirectToAction("Activation", "Account", new { username = username , password = password });
                }
            }
                
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.Home.AdvisorId == userid && a.Home.Usertype == DomainLayer.Enums.UserType.User).ToList();
            var citymahale = new HomeProperty();
            citymahale.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            citymahale.Regions = await _context.RegionRepository.GetAllAsync();
            citymahale.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            citymahale.Cities = citymahale.Cities.OrderBy(a => a.Name).ToList();
            citymahale.Regions = citymahale.Regions.OrderBy(a => a.Name).ToList();
            main.HomeProperty = citymahale;
            return View(main);
        }

        public async Task<IActionResult> CreateContract2(int userid,int homeid,int hometype)
        {
            var main = new ViewModelLayer.User.UserMain();
            main.User = _context.UserRepository.GetById(userid);
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.Home.AdvisorId == userid && a.Home.Usertype == DomainLayer.Enums.UserType.User).ToList();
            var citymahale = new HomeProperty();
            citymahale.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            citymahale.Regions = await _context.RegionRepository.GetAllAsync();
            citymahale.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            main.HomeProperty = citymahale;
            ViewData["homeid"] = homeid;
            ViewData["hometype"] = hometype;
            return View(main);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Home home, int typehome, string txtkuche, IFormFile homeImage, IFormFile pelanImage,int userid,string conty)
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
                        home.Address += " کوچه " + txtkuche;
                    }
                    if (conty != null)
                    {
                        var findcity = await _context.CityRepository.GetAsync(a => a.Name.Contains(conty));
                        var findhomesfinal = await _context.HomeRepository.GetManyAsync(a => a.Address.Contains(conty));
                        var homecounts = findhomesfinal.OrderByDescending(a => a.Id).FirstOrDefault();

                        if (findcity != null)
                        {
                            if (homecounts == null)
                            {
                                home.Code = RandomNumber.MakeKey(findcity.Code, 0);
                            }
                            else
                            {
                                home.Code = RandomNumber.MakeKey(findcity.Code, homecounts.Id);
                            }

                            home.AdvisorId = userid;
                            home.Usertype = DomainLayer.Enums.UserType.User;
                            home.Hometype = typehome;
                            _context.HomeRepository.Insert(home);
                            await _context.CommitAsync();
                        }
                    }
                    
                    return OpenUrl(typehome, home.Id,userid);
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
                await _context.CommitAsync();
            }
            return RedirectToAction("CreateContract","UserManagment",new { userid=userid});
        }

        public IActionResult OpenUrl(int typename, int id,int userid)
        {
            if (typename == 1)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new {userid=userid , homeid = id, hometype = 1, text = "آپارتمان" });
            }
            else if (typename == 2)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 2, text = "خانه حیاط دار" });
            }
            else if (typename == 3)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 3, text = "زمین" });
            }
            else if (typename == 4)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 4, text = "کلنگی" });
            }
            else if (typename == 5)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 5, text = "اداری" });
            }
            else if (typename == 6)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 6, text = "مغازه" });
            }
            else if (typename == 7)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 7, text = "مستقلات" });
            }
            else if (typename == 8)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 8, text = "انبار" });
            }
            else if (typename == 9)
            {
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 9, text = "ویلا" });
            }
            return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = id, hometype = 10, text = "باغ و باغچه" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContractItem(Contract Contract, int hometype, string costbuy, string costrahn, string costejare,int userid)
        {
            try
            {
                Contract.BuyCost = Convert.ToInt64(costbuy.Replace(",", ""));
                Contract.RentCOst = Convert.ToInt64(costejare.Replace(",", ""));
                Contract.Vadie = Convert.ToInt64(costrahn.Replace(",", ""));
                if (ModelState.IsValid)
                {
                    Contract.Date = DateTime.Now;
                    _context.ContractRepository.Insert(Contract);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "ContractManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "ContractManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
                return RedirectToAction("CreateContract2", "UserManagment", new {userid=userid, homeid = Contract.Id, hometype = hometype, text = "خانه" });
            }
            return OpenContractUrl(hometype, Contract.HomeId, Contract.TypContract,userid);
        }

        public IActionResult OpenContractUrl(int typename, int id, TypeHome contracttypeid,int userid)
        {
            if (typename == 1)
            {
                return RedirectToAction("ApartemanCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid , userid = userid});
            }
            else if (typename == 2)
            {
                return RedirectToAction("HomewithGardenCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 3)
            {
                return RedirectToAction("ZaminCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 4)
            {
                return RedirectToAction("KolangiCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 5)
            {
                return RedirectToAction("EdariCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 6)
            {
                return RedirectToAction("MaghazeCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 7)
            {
                return RedirectToAction("MostaghelatCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 8)
            {
                return RedirectToAction("AnbarCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            else if (typename == 9)
            {
                return RedirectToAction("GardenCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
            }
            return RedirectToAction("VillaCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
        }

    }
}
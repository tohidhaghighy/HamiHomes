using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.Karshenas.Models;
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

namespace AmlakWebApplication.Karshenas.Controllers
{
    public class RezomeController : Controller
    {
        IUnitofWork _context;

        public RezomeController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index(int id)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(id);
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == id && a.Home.Usertype == DomainLayer.Enums.UserType.Adviser).ToList();
            return View(main);
        }

        public async Task<IActionResult> Create(int id)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(id);
            var home = new HomeProperty();
            home.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            home.Regions = await _context.RegionRepository.GetAllAsync();
            home.Cities = home.Cities.OrderBy(a => a.Name).ToList();
            home.Regions = home.Regions.OrderBy(a => a.Name).ToList();
            main.HomeProperty = home;
            return View(main);
        }

        public async Task<IActionResult> Contract(int userid,int homeid,int hometype,string text)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(userid);
            ViewData["homeid"] = homeid;
            ViewData["hometype"] = hometype;
            return View(main);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Home home, int typehome, string txtkuche, IFormFile homeImage, IFormFile pelanImage, int adviserid, string conty)
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

                            home.AdvisorId = adviserid;
                            home.Usertype = DomainLayer.Enums.UserType.Adviser;
                            home.Hometype = typehome;
                            _context.HomeRepository.Insert(home);
                            await _context.CommitAsync();
                        }
                    }

                    return OpenUrl(typehome, home.Id, adviserid);
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
            return RedirectToAction("CreateContract", "UserManagment", new { adviserid = adviserid });
        }

        public IActionResult OpenUrl(int typename, int id, int userid)
        {
            if (typename == 1)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 1, text = "آپارتمان" });
            }
            else if (typename == 2)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 2, text = "خانه حیاط دار" });
            }
            else if (typename == 3)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 3, text = "زمین" });
            }
            else if (typename == 4)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 4, text = "کلنگی" });
            }
            else if (typename == 5)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 5, text = "اداری" });
            }
            else if (typename == 6)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 6, text = "مغازه" });
            }
            else if (typename == 7)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 7, text = "مستقلات" });
            }
            else if (typename == 8)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 8, text = "انبار" });
            }
            else if (typename == 9)
            {
                return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 9, text = "ویلا" });
            }
            return RedirectToAction("Contract", "Rezome", new { userid = userid, homeid = id, hometype = 10, text = "باغ و باغچه" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContractItem(Contract Contract, int hometype, string costbuy, string costrahn, string costejare, int userid,int homeid,int typecontract)
        {
            try
            {
                Contract.BuyCost = Convert.ToInt64(costbuy.Replace(",", ""));
                Contract.RentCOst = Convert.ToInt64(costejare.Replace(",", ""));
                Contract.Vadie = Convert.ToInt64(costrahn.Replace(",", ""));
                Contract.TypContract = (DomainLayer.Enums.TypeHome)typecontract;
                Contract.HomeId = homeid;
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
                return RedirectToAction("CreateContract2", "UserManagment", new { userid = userid, homeid = Contract.Id, hometype = hometype, text = "خانه" });
            }
            return OpenContractUrl(hometype, Contract.HomeId, Contract.TypContract, userid);
        }

        public IActionResult OpenContractUrl(int typename, int id, TypeHome contracttypeid, int userid)
        {
            if (typename == 1)
            {
                return RedirectToAction("ApartemanCreate", "AllHomeType", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid, userid = userid });
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
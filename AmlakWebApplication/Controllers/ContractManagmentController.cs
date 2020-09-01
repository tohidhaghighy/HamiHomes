using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Contract;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
{
    public class ContractManagmentController : Controller
    {
        IUnitofWork _context;

        public ContractManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index(int homeid,int hometype)
        {
            ViewData["homeid"] = homeid;
            ViewData["hometype"] = hometype;
            return View(_context.ContractRepository.GetAllWithWhereandInclude("Adviser", a=>a.HomeId==homeid).ToList());
        }

        public async Task<IActionResult> Create(int homeid, int hometype,string text)
        {
            var item = new ViewModelLayer.Contract.Contractlist();
            ViewData["type"] = text;
            ViewData["homeid"] = homeid;
            ViewData["hometype"] = hometype;
            item.Advisers = await _context.AdviserRepository.GetManyAsync(a=>a.Active==true);
            return View(item);
        }

        public async Task<IActionResult> Update(int homeid, int hometype, string text,int contractid)
        {
            var item = new ViewModelLayer.Contract.Contractlist();
            ViewData["type"] = text;
            ViewData["homeid"] = homeid;
            ViewData["hometype"] = hometype;
            item.Advisers = await _context.AdviserRepository.GetManyAsync(a => a.Active == true);
            item.Contract = _context.ContractRepository.GetById(contractid);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Contract Contract,int hometype,string costbuy,string costrahn,string costejare)
        {
            try
            {
                Contract.SellCOst = Convert.ToInt64(costbuy.Replace(",", ""));
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
            catch(Exception ex)
            {
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "ContractManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = Contract.Id, hometype = hometype , text = "خانه" });
            }
            return OpenUrl(hometype,Contract.HomeId,Contract.TypContract);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Contract Contract, int hometype, string costbuy, string costrahn, string costejare)
        {
            try
            {
                Contract.SellCOst = Convert.ToInt64(costbuy.Replace(",", ""));
                Contract.RentCOst = Convert.ToInt64(costejare.Replace(",", ""));
                Contract.Vadie = Convert.ToInt64(costrahn.Replace(",", ""));
                if (ModelState.IsValid)
                {
                    Contract.Date = DateTime.Now;
                    _context.ContractRepository.Update(Contract);
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
                return RedirectToAction(nameof(Create), "ContractManagment", new { homeid = Contract.Id, hometype = hometype, text = "خانه" });
            }
            return OpenUrl(hometype, Contract.HomeId, Contract.TypContract);
        }


        public IActionResult OpenUrl(int typename, int id,TypeHome contracttypeid)
        {
            if (typename == 1)
            {
                return RedirectToAction(nameof(Create), "HomeApartemanManagment", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 2)
            {
                return RedirectToAction(nameof(Create), "HomeWithGardenManagment", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 3)
            {
                return RedirectToAction(nameof(Create), "HomeGround", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 4)
            {
                return RedirectToAction(nameof(Create), "HomeKolangi", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 5)
            {
                return RedirectToAction(nameof(Create), "HomeEdari", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 6)
            {
                return RedirectToAction(nameof(Create), "HomeMaghaze", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 7)
            {
                return RedirectToAction(nameof(Create), "HomeMostaghelat", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 8)
            {
                return RedirectToAction(nameof(Create), "HomeAnbarManagment", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            else if (typename == 9)
            {
                return RedirectToAction(nameof(Create), "HomeVilaManagment", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
            }
            return RedirectToAction(nameof(Create), "HomeGardenManagment", new { homeid = id, hometype = typename, contracttype = (int)contracttypeid });
        }

        
        public async Task<JsonResult> AdviserInfo(int id)
        {
            var allinfo = new AdviserInfo();
            var find = await _context.AdviserRepository.GetAllAsync();
            foreach (var item in find)
            {
                allinfo.Name += item.Name + " " + item.Family + ",";
                var getallcontracts = await _context.ContractRepository.GetManyAsync(a=>a.AdviserId==item.Id);
                allinfo.Sold += getallcontracts.Where(a => a.TypContract == DomainLayer.Enums.TypeHome.Selled).Count().ToString() + ",";
                allinfo.Rented += getallcontracts.Where(a => a.TypContract == DomainLayer.Enums.TypeHome.Rented).Count().ToString() + ",";
                allinfo.Builded += getallcontracts.Where(a => a.TypContract == DomainLayer.Enums.TypeHome.builded).Count().ToString() + ",";
            }
            return Json(allinfo);
        }
    }

    public class AdviserInfo
    {
        public string Name { get; set; }
        public string Sold { get; set; }
        public string Rented { get; set; }
        public string Builded { get; set; }
    }
}
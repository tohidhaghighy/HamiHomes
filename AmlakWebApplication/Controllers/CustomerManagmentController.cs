using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Random;

namespace AmlakWebApplication.Controllers
{
    public class CustomerManagmentController : Controller
    {
        IUnitofWork _context;

        public CustomerManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(_context.CustomerRepository.GetById(id));
        }

        public async Task<PartialViewResult> GetPartial(string name,string mahalle)
        {
            return PartialView("_ListAjax", await _context.CustomerRepository.GetManyAsync(a=>a.Name.Contains(name) || a.Family.Contains(name) || a.Address.Contains(mahalle)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(Customer costumer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    costumer.Code = RandomNumber.MakeCustomerKey(await _context.CustomerRepository.GetCount());
                    _context.CustomerRepository.Insert(costumer);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CustomerManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Customer costumer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.CustomerRepository.Update(costumer);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CustomerManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.CustomerRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "CustomerManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        public async Task<PartialViewResult> SearchcustomerPartial(string name, string family,string code)
        {
            return PartialView("_Customerlist", await _context.CustomerRepository.GetManyAsync(a => a.Name.Contains(name) || a.Family.Contains(family) || a.Code.Contains(code)));
        }

        [HttpGet]
        public async Task<JsonResult> GetCustomer(int id)
        {
            try
            {
                return Json(_context.CustomerRepository.GetById(id));
                
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "GetCustomer",
                    LogText = ex.ToString(),
                    LogView = "get"
                });
            }
            return null;
        }
    }
}
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
using ViewModelLayer;
using ViewModelLayer.Facility;

namespace AmlakWebApplication.Controllers
{
    public class HomeFacilityManagmentController : Controller
    {
        IUnitofWork _context;

        public HomeFacilityManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeFacilityRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            var item = new FacilityItems();
            var hometypelist = new List<KeyValue>() { new KeyValue() { Id=1,Name= "خرید و فروش" } ,
             new KeyValue() { Id=2,Name= "رهن و اجاره" } ,
             new KeyValue() { Id=3,Name= "ساخت و ساز" } };
            var melktypelist = new List<KeyValue>() { new KeyValue() { Id=1,Name= "آپارتمان" } ,
             new KeyValue() { Id=2,Name= "خانه حیاط دار" } ,
             new KeyValue() { Id=3,Name= "زمین" },
            new KeyValue() { Id=4,Name= "کلنگی" },
            new KeyValue() { Id=5,Name= "اداری" },
            new KeyValue() { Id=6,Name= "مغازه" },
            new KeyValue() { Id=7,Name= "مستقلات" },
            new KeyValue() { Id=8,Name= "انبار " },
            new KeyValue() { Id=9,Name= "باغ" },new KeyValue() { Id=10,Name= "ویلا" }};
            item.Hometypes = hometypelist;
            item.MelkTypes = melktypelist;
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(HomeFacility homefacility, IFormFile Icon, int MelkTypeId, int HomeTypeId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Icon != null)
                    {
                        var fileName = Guid.NewGuid() + Icon.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Icon.CopyToAsync(stream);
                        }
                        homefacility.Icon = ImageUrl.url + fileName;
                    }
                    homefacility.MelkType = (MelkType)MelkTypeId;
                    homefacility.TypeHome = (TypeHome)HomeTypeId;
                    _context.HomeFacilityRepository.Insert(homefacility);
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeFacilityManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<Boolean> Delete(int id)
        {
            try
            {
                _context.HomeFacilityRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "HomeFacilityManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }

        [HttpPost]
        public async Task<Boolean> SearchStatus(int id)
        {
            try
            {
                await _context.HomeFacilityRepository.ChangeStatus(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AmlaksettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }
    }
}
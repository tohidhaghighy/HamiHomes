using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using System.IO;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.AdvisorManagment;
using Utilities.Hash;
using Microsoft.EntityFrameworkCore;

namespace AmlakWebApplication.Controllers
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
            var main = new MainAdvisor();
            main.Adviser = _context.AdviserRepository.GetById(id);
            var find = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == id);
            main.sellCount = find.Where(a => a.TypContract == TypeHome.Buy).Count();
            main.soldCount = find.Where(a => a.TypContract == TypeHome.Selled).Count();
            main.buildCount = find.Where(a => a.TypContract == TypeHome.build).Count();
            main.buildedCount = find.Where(a => a.TypContract == TypeHome.builded).Count();
            main.rentCount = find.Where(a => a.TypContract == TypeHome.Rent).Count();
            main.rentedCount = find.Where(a => a.TypContract == TypeHome.Rented).Count();
            return View(main);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(Adviser adviser, IFormFile Image, IFormFile BackgroundImage)
        {
            var findadviser = _context.AdviserRepository.GetById(adviser.Id);
            if (Image != null)
            {
                var fileName = Guid.NewGuid() + Image.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);

                }
                findadviser.Image = fileName;
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
                findadviser.BackgroundImage = fileName;
            }

            if (adviser.Password != "" && adviser.Password != null)
            {
                findadviser.Password = adviser.Password.GetHashPassword();
            }
            findadviser.BuyTakhasos = adviser.BuyTakhasos;
            findadviser.Description = adviser.Description;
            findadviser.Email = adviser.Email;
            findadviser.ExperienceYear = adviser.ExperienceYear;
            findadviser.Name = adviser.Name;
            findadviser.Family = adviser.Family;
            findadviser.Mobile = adviser.Mobile;
            findadviser.RentTakhasos = adviser.RentTakhasos;

            _context.AdviserRepository.Update(findadviser);
            await _context.CommitAsync();
            return RedirectToAction(nameof(Index),"Rezome",new { id = adviser.Id});
        } 
    }
}
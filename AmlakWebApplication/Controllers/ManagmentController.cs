using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Panel;

namespace AmlakWebApplication.Controllers
{
    public class ManagmentController : Controller
    {
        IUnitofWork _context;

        public ManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index()
        {
            var main = new Main();
            main.UserCount = await _context.UserRepository.GetCount();
            main.AdvisorCount = await _context.AdviserRepository.GetCount();
            main.HomewithgardenCount = await _context.HomeWithGardenRepository.GetCount();
            main.AnbarCount = await _context.HomeAnbarRepository.GetCount();
            main.ApartemanCount = await _context.HomeApartemanRepository.GetCount();
            main.EdariCount = await _context.HomeEdariRepository.GetCount();
            main.GardenCount = await _context.HomeGardenRepository.GetCount();
            main.KolangiCount = await _context.HomeKolangiRepository.GetCount();
            main.MaghazeCount = await _context.MaghazeRepository.GetCount();
            main.MostaghelatCount = await _context.MoshtghelatRepository.GetCount();
            main.VilaCount = await _context.VilaRepository.GetCount();
            main.ZaminCount = await _context.ZaminRepository.GetCount();
            return View(main);
        }
    }
}
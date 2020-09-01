using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;
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
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == id).ToList();
            return View(main);
        }

        public async Task<IActionResult> Create(int id)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(id);
            var home = new HomeProperty();
            home.Cities = await _context.CityRepository.GetManyAsyncWithInclude("Region");
            home.Mahalles = await _context.MahalleRepository.GetManyAsyncWithInclude("Nahie");
            main.HomeProperty = home;
            return View(main);
        }

        public async Task<IActionResult> Contract(int id)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(id);
            return View(main);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Sazande.Controllers
{
    public class ManagmentController : Controller
    {
        IUnitofWork _context;

        public ManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index(int adviserid)
        {
            var main = new ViewModelLayer.Adviser.AdviserMain();
            main.Adviser = _context.AdviserRepository.GetById(adviserid);
            main.homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.AdviserId == adviserid && a.Home.Usertype == DomainLayer.Enums.UserType.Adviser).ToList();
            return View(main);
        }
    }
}
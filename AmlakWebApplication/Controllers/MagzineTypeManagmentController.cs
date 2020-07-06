using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Controllers
{
    public class MagzineTypeManagmentController : Controller
    {
        IUnitofWork _context;

        public MagzineTypeManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.MagzineTypeRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }


    }
}
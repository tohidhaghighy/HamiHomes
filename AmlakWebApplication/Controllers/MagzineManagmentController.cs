using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Controllers
{
    public class MagzineManagmentController : Controller
    {
        IUnitofWork _context;

        public MagzineManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.MagzineRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Controllers
{
    public class SazandeManagmentController : Controller
    {
        IUnitofWork _context;

        public SazandeManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
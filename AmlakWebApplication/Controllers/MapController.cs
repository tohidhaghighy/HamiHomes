using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Controllers
{
    public class MapController : Controller
    {
        IUnitofWork _context;

        public MapController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
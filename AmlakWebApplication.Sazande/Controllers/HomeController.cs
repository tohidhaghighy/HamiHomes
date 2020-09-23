using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmlakWebApplication.Sazande.Models;
using DataLayer.Infrastracture;
using ViewModelLayer.Login;
using Microsoft.EntityFrameworkCore;
using DomainLayer;
using Microsoft.AspNetCore.Http;

namespace AmlakWebApplication.Sazande.Controllers
{
    public class HomeController : Controller
    {
        IUnitofWork _context;

        public HomeController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index()
        {
            //string username = Request.Cookies["karshenasusername"];
            //string password = Request.Cookies["karshenaspassword"];
            //if (username != "" && password != "")
            //{
            //    var finduser = await _context.AdviserRepository.Login(username, password);
            //    if (finduser != null)
            //    {
            //        return RedirectToAction(nameof(Index), "Managment", new { adviserid = finduser.Id });
            //    }
            //}
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var finduser = await _context.AdviserRepository.Login(login.Username, login.Password);
                    if (finduser != null)
                    {
                        if (login.RememberMe)
                        {
                            this.Set("karshenasusername", login.Username, 20);
                            this.Set("karshenaspassword", login.Password, 20);
                        }

                        return RedirectToAction(nameof(Index), "Managment", new { adviserid = finduser.Id });
                    }

                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "نام کاربری و پسورد نباید خالی باشد");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AccountManagment",
                    LogText = ex.ToString(),
                    LogView = "Login"
                });

            }
            return RedirectToAction(nameof(Index));
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddDays(20);
            else
                option.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Append(key, value, option);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

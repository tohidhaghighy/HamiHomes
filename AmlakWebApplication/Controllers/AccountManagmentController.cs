using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.Hash;
using ViewModelLayer.Login;

namespace AmlakWebApplication.Controllers
{
    public class AccountManagmentController : Controller
    {
        IUnitofWork _context;

        public AccountManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> Index()
        {
            string username = Request.Cookies["username"];
            string password = Request.Cookies["password"];
            if (username!="" && password!="")
            {
                if (await _context.AdminRepository.Login(username, password))
                {
                    return RedirectToAction(nameof(Index), "Managment");
                }
            }
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
                    if (await _context.AdminRepository.Login(login.Username , login.Password))
                    {
                        if (login.RememberMe)
                        {
                            this.Set("username", login.Username, 20);
                            this.Set("password", login.Password, 20);
                        }
                        return RedirectToAction(nameof(Index), "Managment");
                    }
                    
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "نام کاربری و پسورد نباید خالی باشد");
                _context.LogRepository.Insert(new Log()
                {
                    LogController="AccountManagment",
                    LogText=ex.ToString(),
                    LogView="Login"
                });
                
            }
            return RedirectToAction(nameof(Index));
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append(key, value, option);
        }
    }
}
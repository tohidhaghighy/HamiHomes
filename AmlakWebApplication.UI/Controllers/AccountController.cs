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
using Utilities.Random;
using Utilities.Smsdotir;
using ViewModelLayer.Login;

namespace AmlakWebApplication.UI.Controllers
{
    public class AccountController : Controller
    {
        IUnitofWork _context;
        public AccountController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Login()
        {
            string username = Request.Cookies["userusername"];
            string password = Request.Cookies["userpassword"];
            if (username != "" && password != "")
            {
                var finduser = await _context.UserRepository.Login(username, password);
                if (finduser != null)
                {
                    if (finduser.Active==true)
                    {
                        return RedirectToAction("Index", "UserManagment", new { userid = finduser.Id });
                    }
                    else
                    {
                        return RedirectToAction("Activation", "Account", new { username = username, password = password });
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        public async Task<IActionResult> Activation(string username,string password)
        {
            ViewData["username"] = username;
            ViewData["pass"] = password;
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            Remove("userusername");
            Remove("userpassword");
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var finduser = await _context.UserRepository.Login(login.Username, login.Password);
                    if (finduser != null)
                    {
                        this.Set("userusername", login.Username, 20);
                        this.Set("userpassword", login.Password, 20);

                        if (finduser.Active == true)
                        {
                            return RedirectToAction("Index", "UserManagment", new { userid = finduser.Id });
                        }
                        else
                        {
                            return RedirectToAction("Activation", "Account", new { username = login.Username, password = login.Password });
                        }
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
                await _context.CommitAsync();

            }
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user,string repass)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (user.Password==repass)
                    {
                        user.Activecode = RandomNumber.RandomDigits(6);
                        user.Active = false;
                        user.Password = HashString.GetHashPassword(user.Password);
                        _context.UserRepository.Insert(user);
                        await _context.CommitAsync();
                        SendSms.SendSmsActivation(user.Mobile, user.Activecode);
                        return RedirectToAction("Activation","Account",new { username=user.Username,password=repass});
                    }
                    else
                    {
                        ModelState.AddModelError("", "پسورد و تکرار پسورد برابر نیست");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "موارد وارد شده صحیح نیست لطفا دقت کنید");
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
                await _context.CommitAsync();

            }
            return RedirectToAction(nameof(Register));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckActivation(string code,string username,string pass)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var finduser = await _context.UserRepository.Login(username, pass);
                    if (finduser != null)
                    {
                        this.Set("userusername", username, 20);
                        this.Set("userpassword", pass, 20);
                        if (finduser.Activecode==code)
                        {
                            await _context.UserRepository.ChangeCheck(finduser.Id);
                            await _context.CommitAsync();
                            return RedirectToAction("Index", "UserManagment", new { userid = finduser.Id });
                        }
                        
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
                    LogView = "Register"
                });
                await _context.CommitAsync();

            }
            return RedirectToAction("Activation", "Account", new { username = username, password = pass });
        }
        

        public void Set(string key, string value, int expireTime)
        {
            CookieOptions option = new CookieOptions();

            option.Expires = DateTime.Now.AddDays(expireTime);

            Response.Cookies.Append(key, value, option);
        }

        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}
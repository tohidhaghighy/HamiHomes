using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AmlakWebApplication.Controllers
{
    public class ToolsController : Controller
    {
        private IHostingEnvironment hostingEnv;

        public ToolsController(IHostingEnvironment env)
        {
            hostingEnv = env;
        }
        public async Task<IActionResult> Index(string url="")
        {
            ViewData["Image"] = url;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(IFormFile Image)
        {
            try
            {
                    if (Image != null)
                    {
                        var fileName = Guid.NewGuid().ToString()+Image.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Image.CopyToAsync(stream);

                        }
                    ViewData["Image"] = "http://panel.hamihomes.com/images/" + fileName;
                    }
            }
            catch (DbUpdateException ex)
            {
                
            }
            return RedirectToAction(nameof(Index),"Tools",new { url = ViewData["Image"] });
        }

        [HttpPost]
        public async Task<IActionResult> UploadImageAsync(IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    var name = Path.GetFileName(file.FileName);
                    if (name != null)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await file.CopyToAsync(stream);

                            // Add watermark
                            var watermarkedStream = new MemoryStream();
                            using (var img = Image.FromStream(stream))
                            {
                                using (var graphic = Graphics.FromImage(img))
                                {
                                    using (var icon = Image.FromFile(@"wwwroot\images\def.jpg"))
                                    {
                                        graphic.DrawImage(icon, new RectangleF(0, img.Height/9, 120, 100));
                                    }
                                    img.Save(watermarkedStream, ImageFormat.Png);
                                }
                                img.Save(hostingEnv.WebRootPath + "/" + name);

                            }
                            return StatusCode(StatusCodes.Status200OK);
                        }
                    }
                }
                return BadRequest();
            }
            catch (Exception e)
            {
               
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
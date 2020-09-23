using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AmlakWebApplication.UI.Models;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer.Gallery;
using ViewModelLayer.Home;

namespace AmlakWebApplication.UI.Controllers
{
    public class AllHomeTypeController : Controller
    {
        IUnitofWork _context;

        public AllHomeTypeController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> AnbarCreate(int homeid, int hometype, int contracttype,int userid)
        {
            var anbar = new AnbarFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            anbar.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            anbar.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(anbar);
        }

        public async Task<IActionResult> ApartemanCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var aparteman = new ApartemanFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            aparteman.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            aparteman.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(aparteman);
        }

        public async Task<IActionResult> EdariCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var Edari = new EdariFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            Edari.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Edari.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(Edari);
        }

        public async Task<IActionResult> GardenCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var Garden = new GardenFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            Garden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Garden.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(Garden);
        }

        public async Task<IActionResult> ZaminCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var Ground = new ZaminFacility();
            var typehomeid = (TypeHome)hometype;
            var contracttypeid = (MelkType)contracttype;
            Ground.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == typehomeid && a.MelkType == contracttypeid);
            Ground.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(Ground);
        }

        public async Task<IActionResult> KolangiCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var Kolangi = new KolangiFacility();
            var contracttypeid = (TypeHome)hometype;
            var typehomeid = (MelkType)contracttype;
            Kolangi.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            Kolangi.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(Kolangi);
        }

        public async Task<IActionResult> MaghazeCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var maghaze = new MaghazeFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            maghaze.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            maghaze.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(maghaze);
        }

        public async Task<IActionResult> MostaghelatCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var mostaghelat = new MostaghelatFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            mostaghelat.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            mostaghelat.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(mostaghelat);
        }

        public async Task<IActionResult> VillaCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var villa = new VilaFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            villa.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            villa.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(villa);
        }

        public async Task<IActionResult> HomewithGardenCreate(int homeid, int hometype, int contracttype, int userid)
        {
            var homewithgarden = new HomeWithGardenFacility();
            var typehomeid = (MelkType)hometype;
            var contracttypeid = (TypeHome)contracttype;
            homewithgarden.AmlakEmtiazes = await _context.AmlakEmtiazRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakDivars = await _context.AmlakDivarRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakEskeletones = await _context.AmlakSkeletonRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakJahatVahedes = await _context.AmlakJahatvahedRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKafes = await _context.AmlakKafRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakKitchenes = await _context.AmlakKitchenRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshaat = await _context.AmlakMoshaatRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakNema = await _context.AmlakNemaRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakParking = await _context.AmlakParkingRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakPishraftStatus = await _context.AmlakPishraftStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSaghf = await _context.AmlakSaghfRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.TypeHome == contracttypeid && a.MelkType == typehomeid);
            homewithgarden.User = _context.UserRepository.GetById(userid);
            ViewData["Id"] = homeid;
            return View(homewithgarden);
        }

        public async Task<IActionResult> Gallery(int homeid,int userid)
        {
            ViewData["Id"] = homeid;
            var gallery = new Gallery();
            gallery.ListGallery = await _context.HomeGalleryRepository.GetManyAsync(a => a.HomeId == homeid);
            gallery.User = _context.UserRepository.GetById(userid);
            return View(gallery);
        }

        [HttpPost]
        public async Task<Boolean> DeleteImage(int id)
        {
            try
            {
                _context.HomeGalleryRepository.Delete(id);
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "GalleryManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
                await _context.CommitAsync();
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadItem(HomeGallery gallery, IFormFile Image ,int userid)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Image != null)
                    {
                        var fileName = Guid.NewGuid() + Image.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                        var watermark_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await Image.CopyToAsync(stream);

                        }
                        gallery.Url = ImageUrl.url + fileName;

                        _context.HomeGalleryRepository.Insert(gallery);
                        await _context.CommitAsync();
                    }

                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "GalleryManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });
                await _context.CommitAsync();
            }
            return RedirectToAction(nameof(Gallery), "AllHomeType", new { homeid = gallery.HomeId ,userid=userid});
        }
    }
}
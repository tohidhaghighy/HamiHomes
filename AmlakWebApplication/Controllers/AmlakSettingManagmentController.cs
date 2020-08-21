using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModelLayer;
using ViewModelLayer.Common;

namespace AmlakWebApplication.Controllers
{
    public class AmlakSettingManagmentController : Controller
    {
        IUnitofWork _context;

        public AmlakSettingManagmentController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async  Task<IActionResult> Divar()
        {
            return View(await _context.AmlakDivarRepository.GetAllAsync());
        }

        public async Task<IActionResult> Emtiaz()
        {
            return View(await _context.AmlakEmtiazRepository.GetAllAsync());
        }

        public async Task<IActionResult> Jahatvahed()
        {
            return View(await _context.AmlakJahatvahedRepository.GetAllAsync());
        }

        public async Task<IActionResult> Kitchen()
        {
            return View(await _context.AmlakKitchenRepository.GetAllAsync());
        }

        public async Task<IActionResult> MelkStatus()
        {
            return View(await _context.AmlakMelStatusRepository.GetAllAsync());
        }

        public async Task<IActionResult> MoghiateMelk()
        {
            return View(await _context.AmlakMoghiateMelkRepository.GetAllAsync());
        }

        public async Task<IActionResult> Moshaat()
        {
            return View(await _context.AmlakMoshaatRepository.GetAllAsync());
        }

        public async Task<IActionResult> Nema()
        {
            return View(await _context.AmlakNemaRepository.GetAllAsync());
        }

        public async Task<IActionResult> NoeZamin()
        {
            return View(await _context.AmlakNoeZaminRepository.GetAllAsync());
        }

        public async Task<IActionResult> Parking()
        {
            return View(await _context.AmlakParkingRepository.GetAllAsync());
        }

        public async Task<IActionResult> PishraftStatus()
        {
            return View(await _context.AmlakPishraftStatusRepository.GetAllAsync());
        }

        public async Task<IActionResult> Saghf()
        {
            return View(await _context.AmlakSaghfRepository.GetAllAsync());
        }

        public async Task<IActionResult> SanadStatus()
        {
            return View(await _context.AmlakSanadStatusRepository.GetAllAsync());
        }

        public async Task<IActionResult> Skeleton()
        {
            return View(await _context.AmlakSkeletonRepository.GetAllAsync());
        }

        public async Task<IActionResult> TasisatGarmaieshi()
        {
            return View(await _context.AmlakTasisatGarmaieshiRepository.GetAllAsync());
        }

        public async Task<IActionResult> Wc()
        {
            return View(await _context.AmlakWcRepository.GetAllAsync());
        }

        public async Task<IActionResult> MoshakhaseMelk()
        {
            return View(await _context.AmlakMoshakhaseRepository.GetAllAsync());
        }

        public async Task<IActionResult> Kaf()
        {
            return View(await _context.AmlakKafRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create(int settingtype,string name)
        {
            var item = new KeyValueList();
            ViewData["Settingtype"] = settingtype;
            ViewData["name"] = name;
            var hometypelist = new List<KeyValue>() { new KeyValue() { Id=1,Name= "خرید و فروش" } ,
             new KeyValue() { Id=2,Name= "رهن و اجاره" } ,
             new KeyValue() { Id=3,Name= "ساخت و ساز" } };
            var melktypelist = new List<KeyValue>() { new KeyValue() { Id=1,Name= "آپارتمان" } ,
             new KeyValue() { Id=2,Name= "خانه حیاط دار" } ,
             new KeyValue() { Id=3,Name= "زمین" },
            new KeyValue() { Id=4,Name= "کلنگی" },
            new KeyValue() { Id=5,Name= "اداری" },
            new KeyValue() { Id=6,Name= "مغازه" },
            new KeyValue() { Id=7,Name= "مستقلات" },
            new KeyValue() { Id=8,Name= "انبار " },
            new KeyValue() { Id=9,Name= "باغ" },new KeyValue() { Id=10,Name= "ویلا" }};
            item.Hometypes = hometypelist;
            item.MelkTypes = melktypelist;
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(int Id,int MelkTypeId,int HomeTypeId,string name)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Id==1)
                    {
                        _context.AmlakDivarRepository.Insert(new AmlakDivar()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id==2)
                    {
                        _context.AmlakEmtiazRepository.Insert(new AmlakEmtiaz()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id==3)
                    {
                        _context.AmlakJahatvahedRepository.Insert(new AmlakJahatVahed()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 4)
                    {
                        _context.AmlakKitchenRepository.Insert(new AmlakKitchen()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 5)
                    {
                        _context.AmlakMelStatusRepository.Insert(new AmlakMelkStatus()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 6)
                    {
                        _context.AmlakMoghiateMelkRepository.Insert(new AmlakMogheiatMelk()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 7)
                    {
                        _context.AmlakMoshaatRepository.Insert(new AmlakMoshaat()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 8)
                    {
                        _context.AmlakMoshakhaseRepository.Insert(new AmlakMoshakhase()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 9)
                    {
                        _context.AmlakNemaRepository.Insert(new AmlakNema()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 10)
                    {
                        _context.AmlakNoeZaminRepository.Insert(new AmlakNoeZamin()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 11)
                    {
                        _context.AmlakParkingRepository.Insert(new AmlakParking()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 12)
                    {
                        _context.AmlakPishraftStatusRepository.Insert(new AmlakPishraftStatus()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 13)
                    {
                        _context.AmlakSaghfRepository.Insert(new AmlakSaghf()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 14)
                    {
                        _context.AmlakSanadStatusRepository.Insert(new AmlakSanadStatus()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 15)
                    {
                        _context.AmlakSkeletonRepository.Insert(new AmlakEskeleton()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 16)
                    {
                        _context.AmlakTasisatGarmaieshiRepository.Insert(new AmlakTasisatGarmaieshi()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 17)
                    {
                        _context.AmlakWcRepository.Insert(new AmlakWC()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    else if (Id == 18)
                    {
                        _context.AmlakKafRepository.Insert(new AmlakKaf()
                        {
                            Name = name,
                            MelkType = (MelkType)MelkTypeId,
                            TypeHome = (TypeHome)HomeTypeId,
                        });
                    }
                    await _context.CommitAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "با مدیر سایت تماس بگیرید مشکل سروری است");
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AmlaksettingManagment",
                    LogText = ex.ToString(),
                    LogView = "CreateItem"
                });

            }
            if (Id == 1)
            {
                return RedirectToAction(nameof(Divar));
            }
            else if (Id == 2)
            {
                return RedirectToAction(nameof(Emtiaz));
            }
            else if (Id == 3)
            {
                return RedirectToAction(nameof(Jahatvahed));
            }
            else if (Id == 4)
            {
                return RedirectToAction(nameof(Kitchen));
            }
            else if (Id == 5)
            {
                return RedirectToAction(nameof(MelkStatus));
            }
            else if (Id == 6)
            {
                return RedirectToAction(nameof(MoghiateMelk));
            }
            else if (Id == 7)
            {
                return RedirectToAction(nameof(Moshaat));
            }
            else if (Id == 8)
            {
                return RedirectToAction(nameof(MoshakhaseMelk));
            }
            else if (Id == 9)
            {
                return RedirectToAction(nameof(Nema));
            }
            else if (Id == 10)
            {
                return RedirectToAction(nameof(NoeZamin));
            }
            else if (Id == 11)
            {
                return RedirectToAction(nameof(Parking));
            }
            else if (Id == 12)
            {
                return RedirectToAction(nameof(PishraftStatus));
            }
            else if (Id == 13)
            {
                return RedirectToAction(nameof(Saghf));
            }
            else if (Id == 14)
            {
                return RedirectToAction(nameof(SanadStatus));
            }
            else if (Id == 15)
            {
                return RedirectToAction(nameof(Skeleton));
            }
            else if (Id == 16)
            {
                return RedirectToAction(nameof(TasisatGarmaieshi));
            }
            else if (Id == 17)
            {
                return RedirectToAction(nameof(Wc));
            }
            else if (Id == 18)
            {
                return RedirectToAction(nameof(Kaf));
            }
            return RedirectToAction(nameof(Divar));
        }


        [HttpPost]
        public async Task<Boolean> Delete(int deleteditem,int Id)
        {
            try
            {
                if (Id == 1)
                {
                    _context.AmlakDivarRepository.Delete(deleteditem);
                }
                else if (Id == 2)
                {
                    _context.AmlakEmtiazRepository.Delete(deleteditem);
                }
                else if (Id == 3)
                {
                    _context.AmlakJahatvahedRepository.Delete(deleteditem);
                }
                else if (Id == 4)
                {
                    _context.AmlakKitchenRepository.Delete(deleteditem);
                }
                else if (Id == 5)
                {
                    _context.AmlakMelStatusRepository.Delete(deleteditem);
                }
                else if (Id == 6)
                {
                    _context.AmlakMoghiateMelkRepository.Delete(deleteditem);
                }
                else if (Id == 7)
                {
                    _context.AmlakMoshaatRepository.Delete(deleteditem);
                }
                else if (Id == 8)
                {
                    _context.AmlakMoshakhaseRepository.Delete(deleteditem);
                }
                else if (Id == 9)
                {
                    _context.AmlakNemaRepository.Delete(deleteditem);
                }
                else if (Id == 10)
                {
                    _context.AmlakNoeZaminRepository.Delete(deleteditem);
                }
                else if (Id == 11)
                {
                    _context.AmlakParkingRepository.Delete(deleteditem);
                }
                else if (Id == 12)
                {
                    _context.AmlakPishraftStatusRepository.Delete(deleteditem);
                }
                else if (Id == 13)
                {
                    _context.AmlakSaghfRepository.Delete(deleteditem);
                }
                else if (Id == 14)
                {
                    _context.AmlakSanadStatusRepository.Delete(deleteditem);
                }
                else if (Id == 15)
                {
                    _context.AmlakSkeletonRepository.Delete(deleteditem);
                }
                else if (Id == 16)
                {
                    _context.AmlakTasisatGarmaieshiRepository.Delete(deleteditem);
                }
                else if (Id == 17)
                {
                    _context.AmlakWcRepository.Delete(deleteditem);
                }
                else if (Id == 18)
                {
                    _context.AmlakKafRepository.Delete(deleteditem);
                }
                await _context.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _context.LogRepository.Insert(new Log()
                {
                    LogController = "AmlaksettingManagment",
                    LogText = ex.ToString(),
                    LogView = "Delete"
                });
            }
            return false;
        }
    }
}
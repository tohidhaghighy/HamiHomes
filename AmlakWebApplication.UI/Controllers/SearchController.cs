using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer.Contract;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Search;
using ViewModelLayer.UI;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmlakWebApplication.UI.Controllers
{
    public class SearchController : Controller
    {
        IUnitofWork _context;

        public SearchController(IUnitofWork repo)
        {
            this._context = repo;
        }

        public async Task<IActionResult> SearchList(int mincost, int maxcost, int minmetr, int maxmetr, int minejare, int maxejare, int selectitem, int typehome)
        {
            ViewData["type"] = typehome;
            var searchlist = new SearchList();
            var find = await ConvertItems(mincost, maxcost, minmetr, maxmetr, minejare, maxejare, selectitem);
            searchlist.ShowItems = find;
            searchlist.MainPage = await GetListMetrCost();
            if (typehome==1)
            {
                if (maxcost!=0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.SellCOst > find.MinCostPrice && a.SellCOst < find.MaxCostPrice && a.Home.IsShow==true).ToList();
                }
                else
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.SellCOst > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }
                
            }
            else if (typehome==2)
            {
                if (maxcost!=0 && maxejare!=0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost!=0 && maxejare==0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost==0 && maxejare!=0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost==0 && maxejare==0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }
               
            }
            else if (typehome==3)
            {
                searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Selled && a.Home.IsShow == true).ToList();
            }

            if (selectitem!=0)
            {
                if (maxmetr!=0)
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= minmetr && a.Metraz <= maxmetr).ToList();
                }
                else
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= minmetr).ToList();
                }
                
            }
            
            return View(searchlist);
        }
        public async Task<PartialViewResult> GetApartemanPartial(int buyrent,int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a=>a.MelkType==hometypeint && a.TypeHome==buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("ApartemanSearchBox",searchlist);
        }

        public async Task<PartialViewResult> GetAnbarPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("AnbarSearchBox", searchlist);
        }

        public async Task<PartialViewResult> GetHomeWithGardenPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("HomeWithGardenSearchBox", searchlist);
        }

        public async Task<PartialViewResult> ZaminPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("ZaminSearchBox", searchlist);
        }

        public async Task<PartialViewResult> KolangiPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("KolangiSearchBox", searchlist);
        }

        public async Task<PartialViewResult> EdariPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("EdariSearchBox", searchlist);
        }

        public async Task<PartialViewResult> MaghazePartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("MaghazeSearchBox", searchlist);
        }

        public async Task<PartialViewResult> MostaghelatPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("MostaghelatSearchBox", searchlist);
        }

        public async Task<PartialViewResult> GardenPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("GardenSearchBox", searchlist);
        }

        public async Task<PartialViewResult> VillaPartial(int buyrent, int hometype)
        {
            var searchlist = new SearchList();
            var buyrenttype = (TypeHome)buyrent;
            var hometypeint = (MelkType)hometype;
            searchlist.AmlakKitchen = await _context.AmlakKitchenRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMelkStatus = await _context.AmlakMelStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMogheiatMelk = await _context.AmlakMoghiateMelkRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakMoshakhase = await _context.AmlakMoshakhaseRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakSanadStatus = await _context.AmlakSanadStatusRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakTasisatGarmaieshi = await _context.AmlakTasisatGarmaieshiRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakWC = await _context.AmlakWcRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.AmlakNoeZamin = await _context.AmlakNoeZaminRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            searchlist.HomeFacility = await _context.HomeFacilityRepository.GetManyAsync(a => a.MelkType == hometypeint && a.TypeHome == buyrenttype);
            return PartialView("VillaSearchBox", searchlist);
        }


        public async Task<ShowItems> ConvertItems(int mincost, int maxcost, int minmetr, int maxmetr, int minejare, int maxejare, int selectitem)
        {
            var items = new ShowItems();
            items.Mincost = "0";
            if (mincost!=0)
            {
                var findmincost = await _context.CostSettingRepository.GetAsync(a=>a.Id==mincost);
                items.Mincost = findmincost.Cost.ToString();
                items.MinCostPrice = findmincost.CostChance;
            }

            items.Maxcost = "0";
            if (maxcost != 0)
            {
                var findmaxcost = await _context.CostSettingRepository.GetAsync(a => a.Id == maxcost);
                items.Maxcost = findmaxcost.Cost.ToString();
                items.MaxCostPrice = findmaxcost.CostChance;
            }

            items.MinEjarecost = "0";
            if (minejare != 0)
            {
                var findminejarecost = await _context.CostSettingRepository.GetAsync(a => a.Id == minejare);
                items.MinEjarecost = findminejarecost.Cost.ToString();
                items.MinEjareCostPrice = findminejarecost.CostChance;
            }

            items.MaxEjarecost = "0";
            if (maxejare != 0)
            {
                var findmaxEjarecost = await _context.CostSettingRepository.GetAsync(a => a.Id == maxejare);
                items.MaxEjarecost = findmaxEjarecost.Cost.ToString();
                items.MaxEjarecostPrice = findmaxEjarecost.CostChance;
            }

            items.MinMetr = "0";
            if (minmetr != 0)
            {
                var findminmetr = await _context.MetrazSettingRepository.GetAsync(a => a.Id == minmetr);
                items.MinMetr = findminmetr.MetrazChance.ToString();
            }

            items.MaxMetr = "0";
            if (maxmetr != 0)
            {
                var findmaxmetr = await _context.MetrazSettingRepository.GetAsync(a => a.Id == maxmetr);
                items.MaxMetr = findmaxmetr.MetrazChance.ToString();
            }

            items.MelknameId = selectitem;
            items.Melkname = "همه";
            if (selectitem != 0)
            {
                var findhomegroup = await _context.HomeGroupRepository.GetAsync(a => a.Id == selectitem);
                items.Melkname = findhomegroup.Name;
            }

            items.ListNahie = await _context.NahieRepository.GetAllAsync();
            return items;
        }

        public async Task<MainPage> GetListMetrCost()
        {
            var main = new MainPage();
            main.CostSetting = await _context.CostSettingRepository.GetAllAsync();
            main.MetrazSetting = await _context.MetrazSettingRepository.GetAllAsync();
            main.EjareSetting = await _context.EjareSettingRepository.GetAllAsync();
            main.VadieSetting = await _context.VadieSettingRepository.GetAllAsync();
            main.CostSetting = main.CostSetting.OrderBy(a => a.CostChance).ToList();
            main.MetrazSetting = main.MetrazSetting.OrderBy(a => a.MetrazChance).ToList();
            main.EjareSetting = main.EjareSetting.OrderBy(a => a.CostChance).ToList();
            main.VadieSetting = main.VadieSetting.OrderBy(a => a.CostChance).ToList();
            return main;
        }

        public async Task<PartialViewResult> SearchAnbarPartial(int hometype,int minmetr,int maxmetr,int mincost,int maxcost,int arzebana, int arzegozar, string sanad,string moghiat,string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            foreach (var item in homes)
            {
                if (item.HomeId!=null)
                {
                    var findanbars = _context.HomeAnbarRepository.GetById(item.HomeId);
                    if (findanbars!=null)
                    {
                        if (moghiat==null)
                        {
                            moghiat = "";
                        }
                        if (findanbars.Arzegozar>=arzegozar && findanbars.Arzemelk>=arzebana && findanbars.MoghiateMelk.Contains(moghiat) && findanbars.SanadStatus.Contains(sanad))
                        {
                            homecontracts.Add(item);
                        }
                    }
                }
            }
            
            
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchApartemanPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed, int parking,int wc,int bana, string wclist, string moghiat,string kitchen, string tasisat,string melkstatus,string sanad, string moshakhase, string rentbuy)
        {
            var homes =await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchEdariPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed, int parking, int wc, int bana, string wclist, string moghiat , string tasisat, string vaziat, string sanad, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchGardenPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed,int arzemelk, string moghiat, string vaziat, string sanad, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchHomewithGardenPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed,int arzemelk,string wclist, string moghiat , string sanad , string kitchen , string tasisat , string vizhe , string moshakhase, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchKolangiPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int arzemelk, int arzegozar, string moghiat, string sanad, string vizhe, string moshakhase,string nozamin, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchMaghazePartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int metrazhkaf, int metrazhdahane,int anbarmetrazh, string moghiat, string sanad, string vizhe, string moshakhase, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchMostaghelatPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed, int parking, int wc, int bana, int metrazhkaf, int metrazhdahane, int arzemelk, string wclist, string moghiat, string kitchen, string tasisat, string nozamin, string sanad, string moshakhase,string vizhe, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchVillaPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int bed, int wc, int bana, int arzemelk, string wclist, string moghiat, string kitchen, string tasisat, string sanad, string moshakhase, string vizhe, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<PartialViewResult> SearchZaminPartial(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, int arzemelk, int arzegozar, string moghiat, string sanad, string moshakhase, string vizhe,string nozamin, string rentbuy)
        {
            var homes = await Returnhomefunction(hometype, minmetr, maxmetr, mincost, maxcost, rentbuy);
            var homecontracts = new List<Contract>();
            return PartialView("_SearchList", homecontracts);
        }

        public async Task<List<Contract>> Returnhomefunction(int hometype, int minmetr, int maxmetr, int mincost, int maxcost, string rentbuy)
        {
            var homes = new List<Contract>();
            var find = await ConvertItems(mincost, maxcost, minmetr, maxmetr, mincost, maxcost, hometype);
            if (rentbuy == "1")
            {
                if (maxcost != 0)
                {
                    homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.SellCOst > find.MinCostPrice && a.SellCOst < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else
                {
                    homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.SellCOst > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (rentbuy == "2")
            {
                if (maxcost != 0)
                {
                    homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else
                {
                    homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (rentbuy == "3")
            {
                homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Selled && a.Home.IsShow == true).ToList();
            }

            if (hometype != 0)
            {
                if (maxmetr != 0)
                {
                    homes = homes.Where(a => a.Home.Hometype == hometype && a.Metraz >= Convert.ToInt32(find.MinMetr) && a.Metraz <= Convert.ToInt32(find.MaxMetr)).ToList();
                }
                else
                {
                    homes = homes.Where(a => a.Home.Hometype == hometype && a.Metraz >= Convert.ToInt32(find.MinMetr)).ToList();
                }

            }
            return homes;
        }
    }
}

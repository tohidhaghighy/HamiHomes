using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
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
            searchlist.ShowItems = await ConvertItems(mincost, maxcost, minmetr, maxmetr, minejare, maxejare, selectitem);
            searchlist.MainPage = await GetListMetrCost();
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
            }

            items.Maxcost = "0";
            if (maxcost != 0)
            {
                var findmaxcost = await _context.CostSettingRepository.GetAsync(a => a.Id == maxcost);
                items.Maxcost = findmaxcost.Cost.ToString();
            }

            items.MinEjarecost = "0";
            if (minejare != 0)
            {
                var findminejarecost = await _context.CostSettingRepository.GetAsync(a => a.Id == minejare);
                items.MinEjarecost = findminejarecost.Cost.ToString();
            }

            items.MaxEjarecost = "0";
            if (maxejare != 0)
            {
                var findmaxEjarecost = await _context.CostSettingRepository.GetAsync(a => a.Id == maxejare);
                items.MaxEjarecost = findmaxEjarecost.Cost.ToString();
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
    }
}

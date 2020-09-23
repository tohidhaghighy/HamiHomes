using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using DomainLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Search;
using ViewModelLayer.UI;

namespace AmlakWebApplication.UI.Controllers
{
    public class RealtimeSearchController : Controller
    {
        IUnitofWork _context;

        public RealtimeSearchController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<PartialViewResult> SearchList(int mincost, int maxcost, int minmetr, int maxmetr, int minejare, int maxejare, int selectitem, int typehome)
        {
            ViewData["type"] = typehome;
            var searchlist = new SearchList();
            var find = await ConvertItems(mincost, maxcost, minmetr, maxmetr, minejare, maxejare, selectitem);
            searchlist.ShowItems = find;
            if (typehome == 1)
            {
                if (maxcost != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.BuyCost > find.MinCostPrice && a.BuyCost < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.BuyCost > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (typehome == 2)
            {
                if (maxcost != 0 && maxejare != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost != 0 && maxejare == 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost == 0 && maxejare != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost == 0 && maxejare == 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (typehome == 3)
            {
                searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Selled && a.Home.IsShow == true).ToList();
            }

            if (selectitem != 0)
            {
                if (maxmetr != 0)
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= find.MinMetrInt && a.Metraz <= find.MaxMetrInt).ToList();
                }
                else
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= find.MinMetrInt).ToList();
                }

            }

            if (maxmetr!=0)
            {
                searchlist.Homes = searchlist.Homes.Where(a => a.Metraz >= find.MinMetrInt && a.Metraz <= find.MaxMetrInt).ToList();
            }
            else
            {
                searchlist.Homes = searchlist.Homes.Where(a => a.Metraz >= find.MinMetrInt).ToList();
            }
            

            return PartialView("_SearchList", searchlist.Homes);
        }

        public async Task<PartialViewResult> SearchListGps(int mincost, int maxcost, int minmetr, int maxmetr, int minejare, int maxejare, int selectitem, int typehome,string gpsx,string gpsy)
        {
            ViewData["type"] = typehome;
            var searchlist = new SearchList();
            var find = await ConvertItems(mincost, maxcost, minmetr, maxmetr, minejare, maxejare, selectitem);
            searchlist.ShowItems = find;
            if (typehome == 1)
            {
                if (maxcost != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.BuyCost > find.MinCostPrice && a.BuyCost < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Buy && a.BuyCost > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (typehome == 2)
            {
                if (maxcost != 0 && maxejare != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost != 0 && maxejare == 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Vadie < find.MaxCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost == 0 && maxejare != 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.RentCOst < find.MaxEjarecostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }
                else if (maxcost == 0 && maxejare == 0)
                {
                    searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Rent && a.RentCOst > find.MinEjareCostPrice && a.Vadie > find.MinCostPrice && a.Home.IsShow == true).ToList();
                }

            }
            else if (typehome == 3)
            {
                searchlist.Homes = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.TypContract == TypeHome.Selled && a.Home.IsShow == true).ToList();
            }

            if (selectitem != 0)
            {
                if (maxmetr != 0)
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= find.MinMetrInt && a.Metraz <= find.MaxMetrInt).ToList();
                }
                else
                {
                    searchlist.Homes = searchlist.Homes.Where(a => a.Home.Hometype == selectitem && a.Metraz >= find.MinMetrInt).ToList();
                }

            }

            if (maxmetr != 0)
            {
                searchlist.Homes = searchlist.Homes.Where(a => a.Metraz >= find.MinMetrInt && a.Metraz <= find.MaxMetrInt).ToList();
            }
            else
            {
                searchlist.Homes = searchlist.Homes.Where(a => a.Metraz >= find.MinMetrInt).ToList();
            }

            string gpsxsub = gpsx.Substring(0, 5);
            string gpsysub = gpsy.Substring(0, 5);
            searchlist.Homes = searchlist.Homes.Where(a => a.Home.Gpsx.StartsWith(gpsxsub) && a.Home.Gpsy.StartsWith(gpsysub)).ToList();

            return PartialView("_SearchList", searchlist.Homes);
        }


        public async Task<ShowItems> ConvertItems(int mincost, int maxcost, int minmetr, int maxmetr, int minejare, int maxejare, int selectitem)
        {
            var items = new ShowItems();
            items.Mincost = "0";
            if (mincost != 0)
            {
                var findmincost = await _context.CostSettingRepository.GetAsync(a => a.Id == mincost);
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
                items.MinMetrInt = findminmetr.MetrazChance;
            }

            items.MaxMetr = "0";
            if (maxmetr != 0)
            {
                var findmaxmetr = await _context.MetrazSettingRepository.GetAsync(a => a.Id == maxmetr);
                items.MaxMetr = findmaxmetr.MetrazChance.ToString();
                items.MaxMetrInt = findmaxmetr.MetrazChance;
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
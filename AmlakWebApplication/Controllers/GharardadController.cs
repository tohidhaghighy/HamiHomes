using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.Controllers
{
    public class GharardadController : Controller
    {
        IUnitofWork _context;

        public GharardadController(IUnitofWork repo)
        {
            this._context = repo;
        }
        public async Task<IActionResult> Index()
        {
            var gharardad = new ViewModelLayer.Gharardad.Gharardad();
            return View(gharardad);
        }

        public async Task<IActionResult> Vagozar()
        {
            var gharardad = new ViewModelLayer.Gharardad.Gharardad();
            return View(gharardad);
        }

        public async Task<PartialViewResult> Showgharardad(string code)
        {
            var gharardad = new ViewModelLayer.Gharardad.Gharardad();
            gharardad.Contract = _context.ContractRepository.GetAllWithWhereandTwoInclude("Home", "Adviser", a => a.Home.Code == code).FirstOrDefault();
            return PartialView("_GharardadInfo", gharardad);
        }

        public async Task<PartialViewResult> ShowgharardadVagozar(string code)
        {
            var gharardad = new ViewModelLayer.Gharardad.Gharardad();
            gharardad.Contract = _context.ContractRepository.GetAllWithWhereandInclude("Home", a => a.Home.Code == code).FirstOrDefault();
            return PartialView("_GharardadVagozar", gharardad);
        }

        [HttpPost]
        public async Task<Boolean> GharardadInsert(int customerid ,int contractid, string numgharar , string cost1,string cost2,string cost3,string date)
        {
            if (cost1==null)
            {
                cost1 = "0";
            }
            if (cost2==null)
            {
                cost2 = "0";
            }
            if (cost3==null)
            {
                cost3 = "0";
            }
            var costbuy = Convert.ToInt64(cost1.Replace(",", ""));
            var costrent = Convert.ToInt64(cost2.Replace(",", ""));
            var costvadie = Convert.ToInt64(cost3.Replace(",", ""));
            var findcontract = _context.ContractRepository.GetById(contractid);
            if (findcontract!=null)
            {
                findcontract.FinalCost1 = costbuy;
                findcontract.FinalCost2 = costrent;
                findcontract.FinalCost3 = costvadie;
                findcontract.CostumerId = customerid;
                if (findcontract.TypContract==DomainLayer.Enums.TypeHome.Buy)
                {
                    findcontract.TypContract = DomainLayer.Enums.TypeHome.Selled;
                }
                else if (findcontract.TypContract == DomainLayer.Enums.TypeHome.Rent)
                {
                    findcontract.TypContract = DomainLayer.Enums.TypeHome.Rented;
                }
                else if (findcontract.TypContract == DomainLayer.Enums.TypeHome.build)
                {
                    findcontract.TypContract = DomainLayer.Enums.TypeHome.builded;
                }
                findcontract.GharardadNumber = numgharar;
                System.String[] userDateParts = date.Split(new[] { "/" }, System.StringSplitOptions.None);
                int userDay = int.Parse(userDateParts[0]);
                int userMonth = int.Parse(userDateParts[1]);
                int userYear = int.Parse(userDateParts[2]);
                System.DateTime userDate = new System.DateTime(userYear, userMonth, userDay);
                findcontract.SellDate = userDate;
                _context.ContractRepository.Update(findcontract);
                await _context.CommitAsync();
                return true;
            }
            return false;
        }

        [HttpPost]
        public async Task<Boolean> GharardadVagozarInsert(int contractid, string date,string text,int status)
        {
            
            var findcontract = _context.ContractRepository.GetById(contractid);
            if (findcontract != null)
            {
                findcontract.FinalCost1 = 0;
                findcontract.FinalCost2 = 0;
                findcontract.FinalCost3 = 0;
                if (status==1)
                {
                    findcontract.TypContract = DomainLayer.Enums.TypeHome.SellWithOther;
                }
                else if (status==2)
                {
                    findcontract.TypContract = DomainLayer.Enums.TypeHome.Cancel;
                }
                
                findcontract.GharardadNumber = "0";
                System.String[] userDateParts = date.Split(new[] { "/" }, System.StringSplitOptions.None);
                int userDay = int.Parse(userDateParts[0]);
                int userMonth = int.Parse(userDateParts[1]);
                int userYear = int.Parse(userDateParts[2]);
                System.DateTime userDate = new System.DateTime(userYear, userMonth, userDay);
                findcontract.SellDate = userDate;
                findcontract.Description = text;
                _context.ContractRepository.Update(findcontract);
                await _context.CommitAsync();
                return true;
            }
            return false;
        }

    }
}
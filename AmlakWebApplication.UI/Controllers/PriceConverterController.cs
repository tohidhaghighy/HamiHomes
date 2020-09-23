using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AmlakWebApplication.UI.Controllers
{
    public class PriceConverterController : Controller
    {
        [HttpPost]
        public async Task<string> AlphabeticPrice(string text)
        {
            return Utilities.Price.Numbertocharprice.num2str(text);
        }
    }
}
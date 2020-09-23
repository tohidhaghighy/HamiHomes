using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Gharardad
{
    public class Gharardad
    {
        public DomainLayer.Contract.Contract Contract { get; set; }
        public DomainLayer.Customer Customer { get; set; }
        public string Date { get; set; }
        public string BuyCost { get; set; }
        public string RahnCost { get; set; }
        public string EjareCost { get; set; }
        public string ContractNumber { get; set; }
    }
}

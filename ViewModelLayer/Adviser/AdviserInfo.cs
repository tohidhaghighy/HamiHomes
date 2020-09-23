using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Adviser
{
    public class AdviserInfo
    {
        public DomainLayer.Adviser Adviser { get; set; }
        public int BuyCount { get; set; }
        public int RentCount { get; set; }
        public int BuildCount { get; set; }
        public int SellCount { get; set; }
        public int RentedCount { get; set; }
    }
}

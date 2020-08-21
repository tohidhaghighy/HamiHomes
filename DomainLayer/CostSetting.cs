using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class CostSetting:BaseEntity<int>
    {
        public string Cost { get; set; }
        public long CostChance { get; set; }
    }
}

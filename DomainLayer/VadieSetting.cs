using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class VadieSetting:BaseEntity<int>
    {
        public string Cost { get; set; }
        public long CostChance { get; set; }
    }
}

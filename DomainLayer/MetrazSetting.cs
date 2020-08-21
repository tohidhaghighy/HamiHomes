using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class MetrazSetting:BaseEntity<int>
    {
        public string Metraz { get; set; }
        public int MetrazChance { get; set; }
        public int TypeMetraz { get; set; }
    }
}

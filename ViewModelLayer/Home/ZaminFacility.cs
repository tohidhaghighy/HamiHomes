using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class ZaminFacility
    {
        public Zamin Zamin { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
    }
}

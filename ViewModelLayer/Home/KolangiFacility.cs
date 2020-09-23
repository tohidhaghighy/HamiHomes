using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class KolangiFacility
    {
        public Kolangi Kolangi { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public DomainLayer.User User { get; set; }
        public DomainLayer.Adviser Adviser { get; set; }
    }
}

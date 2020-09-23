using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class MaghazeFacility
    {
        public Maghaze Maghaze { get; set; }
        public List<AmlakDivar> AmlakDivars { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public List<AmlakParking> AmlakParking { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public List<AmlakWC> AmlakWC { get; set; }
        public DomainLayer.User User { get; set; }
        public DomainLayer.Adviser Adviser { get; set; }
    }
}

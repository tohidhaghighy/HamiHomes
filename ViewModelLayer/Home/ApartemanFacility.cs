using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class ApartemanFacility
    {
        public Aparteman Aparteman { get; set; }
        public List<AmlakDivar> AmlakDivars { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public List<AmlakEskeleton> AmlakEskeletones { get; set; }
        public List<AmlakJahatVahed> AmlakJahatVahedes { get; set; }
        public List<AmlakKaf> AmlakKafes { get; set; }
        public List<AmlakKitchen> AmlakKitchenes { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMoshaat> AmlakMoshaat { get; set; }
        public List<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public List<AmlakNema> AmlakNema { get; set; }
        public List<AmlakNoeZamin> AmlakNoeZamin { get; set; }
        public List<AmlakParking> AmlakParking { get; set; }
        public List<AmlakPishraftStatus> AmlakPishraftStatus { get; set; }
        public List<AmlakSaghf> AmlakSaghf { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public List<AmlakTasisatGarmaieshi> AmlakTasisatGarmaieshi { get; set; }
        public List<AmlakWC> AmlakWC { get; set; }
        public List<HomeFacility> HomeFacility { get; set; }
    }
}

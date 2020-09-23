using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class AnbarFacility
    {
        public Anbar Anbar { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public string[] Selectedlist { get; set; }
        public DomainLayer.User User { get; set; }
        public DomainLayer.Adviser Adviser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Detail
{
    public class Detailpage
    {
        public DomainLayer.Home.Home home { get; set; }
        public List<DomainLayer.Home.HomeGallery> gallery { get; set; }
        public DomainLayer.Contract.Contract contract { get; set; }
        public DomainLayer.Home.Anbar anbar { get; set; }
        public DomainLayer.Home.Aparteman aparteman { get; set; }
        public DomainLayer.Home.Edari edari { get; set; }
        public DomainLayer.Home.Garden garden { get; set; }
        public DomainLayer.Home.GardenWithVila gardenwithvila { get; set; }
        public DomainLayer.Home.HomewithGarden homewithgarden { get; set; }
        public DomainLayer.Home.Kolangi kolangi { get; set; }
        public DomainLayer.Home.Maghaze maghaze { get; set; }
        public DomainLayer.Home.Moshtghelat moshtghelat { get; set; }
        public DomainLayer.Home.Vila vila { get; set; }
        public DomainLayer.Home.Zamin zamin { get; set; }
        public DomainLayer.HomeFacility Homefacility { get; set; }
        public List<DomainLayer.Contract.Contract> Samehome { get; set; }
    }
}

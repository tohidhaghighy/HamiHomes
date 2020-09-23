using DomainLayer;
using DomainLayer.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class GardenFacility
    {
        public Garden Garden { get; set; }
        public List<AmlakEmtiaz> AmlakEmtiazes { get; set; }
        public DomainLayer.User User { get; set; }
        public DomainLayer.Adviser Adviser { get; set; }
    }
}

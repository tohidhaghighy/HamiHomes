using DomainLayer;
using DomainLayer.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.HomeManagment
{
    public class MainSearch
    {
        public List<DomainLayer.Home.Home> Homes { get; set; }
        public List<Mahalle> Mahalles { get; set; }
        public List<CostSetting> CostSetting { get; set; }
        public List<EjareSetting> EjareSetting { get; set; }
        public List<MetrazSetting> MetrazSetting { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DomainLayer;

namespace ViewModelLayer.City
{
    public class CityRegionViewModel
    {
        public DomainLayer.City City { get; set; }
        public List<DomainLayer.Region> Regions { get; set; }
    }
}

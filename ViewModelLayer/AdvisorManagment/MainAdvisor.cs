
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.AdvisorManagment
{
    public class MainAdvisor
    {
        public DomainLayer.Adviser Adviser { get; set; }
        public List<DomainLayer.Location.Mahalle> Mahalles { get; set; }
        public List<DomainLayer.Region> Regions { get; set; }
        public List<DomainLayer.City> Cities { get; set; }
        public int buildCount { get; set; }
        public int buildedCount { get; set; }
        public int sellCount { get; set; }
        public int soldCount { get; set; }
        public int rentCount { get; set; }
        public int rentedCount { get; set; }
    }
}

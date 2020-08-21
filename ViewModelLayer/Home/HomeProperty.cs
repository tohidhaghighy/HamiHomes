using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Home
{
    public class HomeProperty
    {
        public DomainLayer.Home.Home Home { get; set; }
        public List<DomainLayer.City> Cities { get; set; }
        public List<DomainLayer.Location.Mahalle> Mahalles { get; set; }
    }
}

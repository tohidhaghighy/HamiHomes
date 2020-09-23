using DomainLayer.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.City
{
    public class NahieDirect
    {
        public int nahieid { get; set; }
        public List<NahieDirections> NahieDirections { get; set; }
        public List<NahieDirections> OnlyThisNahieDirections { get; set; }
        public List<Mahalle> Mahalle { get; set; }
        public List<Nahie> Nahie { get; set; }
    }
}

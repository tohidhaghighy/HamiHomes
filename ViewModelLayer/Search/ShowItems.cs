﻿using DomainLayer.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Search
{
    public class ShowItems
    {
        public string Melkname { get; set; }
        public int MelknameId { get; set; }
        public string Mincost { get; set; }
        public long MinCostPrice { get; set; }
        public string Maxcost { get; set; }
        public long MaxCostPrice { get; set; }
        public string MinEjarecost { get; set; }
        public long MinEjareCostPrice { get; set; }
        public string MaxEjarecost { get; set; }
        public long MaxEjarecostPrice { get; set; }
        public string MinMetr { get; set; }
        public int MinMetrInt { get; set; }
        public string MaxMetr { get; set; }
        public int MaxMetrInt { get; set; }

        public List<Nahie> ListNahie { get; set; }
    }
}

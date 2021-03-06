﻿using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLayer.Search;

namespace ViewModelLayer.UI
{
    public class VillaSearch
    {
        public ShowItems ShowItems { get; set; }
        public List<AmlakWC> AmlakWC { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public List<AmlakTasisatGarmaieshi> AmlakTasisatGarmaieshi { get; set; }
        public List<AmlakKitchen> AmlakKitchen { get; set; }
        public List<HomeFacility> HomeFacility { get; set; }
    }
}

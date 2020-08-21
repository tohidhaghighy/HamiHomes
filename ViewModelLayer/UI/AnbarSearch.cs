using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLayer.Search;

namespace ViewModelLayer.UI
{
    public class AnbarSearch
    {
        public ShowItems ShowItems { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
    }
}

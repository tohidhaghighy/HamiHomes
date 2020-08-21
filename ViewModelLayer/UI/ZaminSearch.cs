using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLayer.Search;

namespace ViewModelLayer.UI
{
    public class ZaminSearch
    {
        public ShowItems ShowItems { get; set; }
        public List<AmlakNoeZamin> AmlakNoeZamin { get; set; }
        public List<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public List<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public List<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public List<AmlakMelkStatus> AmlakMelkStatus { get; set; }
    }
}

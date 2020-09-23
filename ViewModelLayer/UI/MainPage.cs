using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.UI
{
    public class MainPage
    {
        public List<DomainLayer.CostSetting> CostSetting { get; set; }
        public List<DomainLayer.EjareSetting> EjareSetting { get; set; }
        public List<DomainLayer.VadieSetting> VadieSetting { get; set; }
        public List<DomainLayer.MetrazSetting> MetrazSetting { get; set; }
        public int Userid { get; set; }
    }
}

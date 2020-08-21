using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class AmlakPishraftStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeHome TypeHome { get; set; }
        public MelkType MelkType { get; set; }
        public Boolean Selected { get; set; }
    }
}

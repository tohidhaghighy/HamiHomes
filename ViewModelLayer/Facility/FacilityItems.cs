using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Facility
{
    public class FacilityItems
    {
        public HomeFacility HomeFacility { get; set; }
        public List<KeyValue> Hometypes { get; set; }
        public List<KeyValue> MelkTypes { get; set; }
    }
}

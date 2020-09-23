using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLayer.Home;

namespace ViewModelLayer.Adviser
{
    public class AdviserMain
    {
        public DomainLayer.Adviser Adviser { get; set; }
        public List<DomainLayer.Contract.Contract> homes { get; set; }
        public HomeProperty HomeProperty { get; set; }
        public DomainLayer.Contract.Contract Contracts { get; set; }
    }
}

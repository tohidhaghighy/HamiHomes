using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Contract
{
    public class Contractlist
    {
        public DomainLayer.Contract.Contract Contract { get; set; }
        public List<DomainLayer.Adviser> Advisers { get; set; }
    }
}

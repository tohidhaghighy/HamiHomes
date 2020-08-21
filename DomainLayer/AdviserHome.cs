using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class AdviserHome:BaseEntity<int>
    {
        public int HomeId { get; set; }
        public int AdviserId { get; set; }
        public AdvisorCV HomeType { get; set; }
    }
}

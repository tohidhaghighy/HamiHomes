using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace DomainLayer
{
    public class Admin:Person
    {
        public Boolean Active { get; set; }
        public AdminType AdminType { get; set; }
    }
}

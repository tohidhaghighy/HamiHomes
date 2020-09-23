using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Location
{
    public class NahieDirections:BaseEntity<int>
    {
        public int NahieId { get; set; }
        public string Gpsx { get; set; }
        public string Gpsy { get; set; }
        //if type==0 nahie  type==1 mahalle
        public int Type { get; set; }
    }
}

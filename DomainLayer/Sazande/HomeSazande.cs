using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Sazande
{
    public class HomeSazande:BaseEntity<int>
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public string NoEskelet { get; set; }
        public int Metrazh { get; set; }
        public int BuildYear { get; set; }
        //maskuni tejari edari
        public string Karbari { get; set; }
        public string Address { get; set; }
        public int HomeType { get; set; }
        public int TabaghatCount { get; set; }
        public string ProjeName { get; set; }
        //==0 darhale sakht  ==1 sakhte shode
        public int BuildSection { get; set; }

        public int SazandeId { get; set; }
    }
}

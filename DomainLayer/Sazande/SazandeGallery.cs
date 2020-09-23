using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Sazande
{
    public class SazandeGallery:BaseEntity<int>
    {
        public string Image { get; set; }
        public int HomeSazandeId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLayer.Gallery
{
    public class Gallery
    {
        public List<DomainLayer.Home.HomeGallery> ListGallery { get; set; }
        public DomainLayer.User User { get; set; }
        public DomainLayer.Adviser Adviser { get; set; }
    }
}

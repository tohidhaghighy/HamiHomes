using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Home
{
    public class HomeGallery:BaseEntity<int>
    {
        public string Url { get; set; }
        public int HomeId { get; set; }

        [ForeignKey(nameof(HomeId))]
        public virtual Home Home { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Magzine
{
    public class MagazinGroup:BaseEntity<int>
    {

        [MaxLength(50, ErrorMessage = "نباید از 50 کارکتر بیشتر شود")]
        public string Name { get; set; }

        public Nullable<int> ParentId { get; set; }

        public virtual ICollection<Magazine> Magazines { get; set; }

    }
}

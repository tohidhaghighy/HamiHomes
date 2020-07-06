using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class MagzineType:BaseEntity<int>
    {
        public MagzineType()
        {
            this.Icon = "";
        }
        [Required(ErrorMessage ="نباید خالی باشد")]
        [MaxLength(100,ErrorMessage ="از 100 کارکتر بیشتر نشود")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "از 500 کارکتر بیشتر نشود")]
        public string Icon { get; set; }

        public Nullable<int> MagzineTypeId { get; set; }

        public virtual ICollection<Magzine> Magzines { get; set; }

    }
}

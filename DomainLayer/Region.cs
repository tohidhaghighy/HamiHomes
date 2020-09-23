using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Region:BaseEntity<int>
    {
        [Required(ErrorMessage ="نباید خالی باشد")]
        [MaxLength(50,ErrorMessage ="کمتر از 50 کلمه باشد")]
        [MinLength(3, ErrorMessage = "بیشتر از 3 کلمه باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsy { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        
    }
}

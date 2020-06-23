using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class HomeGroup:BaseEntity<int>
    {
        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "باید کمتر از 50 کلمه باشد")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "باید کمتر از 500 کلمه باشد")]
        public string Icon { get; set; }
    }
}

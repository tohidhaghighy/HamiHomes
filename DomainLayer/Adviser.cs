using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Adviser : Person
    {
        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(20, ErrorMessage = "باید کمتر از 20 کلمه باشد")]
        public string Mobile { get; set; }
        public Boolean Active { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class User:Person
    {
        [Required(ErrorMessage ="نباید خالی باشد")]
        [MaxLength(20,ErrorMessage ="باید کمتر از 20 کلمه باشد")]
        public string Mobile { get; set; }

        public Boolean Active { get; set; }

        [MaxLength(20, ErrorMessage = "باید کمتر از 20 کلمه باشد")]
        public string Activecode { get; set; }
    }
}

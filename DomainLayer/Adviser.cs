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

        [MaxLength(500, ErrorMessage = "باید کمتر از 500 کلمه باشد")]
        public string Image { get; set; }

        [MaxLength(500, ErrorMessage = "باید کمتر از 500 کلمه باشد")]
        public string BackgroundImage { get; set; }

        [Required(ErrorMessage ="نباید خالی باشد")]
        public int ExperienceYear { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage =" متن وارده ایمیل نمیباشد")]
        public string Email { get; set; }

        [MaxLength(1000, ErrorMessage = "باید کمتر از 1000 کلمه باشد")]
        public string Description { get; set; }
        public string BuyTakhasos { get; set; }
        public string RentTakhasos { get; set; }

        public Boolean Active { get; set; }
        public Boolean CanAdd { get; set; }

        public virtual ICollection<Contract.Contract> Contracts { get; set; }
    }
}

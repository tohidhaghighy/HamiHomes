using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }

        [Required(ErrorMessage ="نباید خالی باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Family { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Number { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Fathername { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Shenasname { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Sadere { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Birthdate { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Address { get; set; }
    }
}

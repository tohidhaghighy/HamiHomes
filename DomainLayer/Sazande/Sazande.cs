using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Sazande
{
    public class Sazande:BaseEntity<int>
    {
        [Required(ErrorMessage ="نباید خالی باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Family { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public string Number { get; set; }
        public string Description { get; set; }
        public string Instagram { get; set; }
        public string Telegram { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public string Image { get; set; }
        public string Sabeghe { get; set; }
        public string CompanyName { get; set; }
        public string ManateghFaaliat { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public int CityId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean Active { get; set; }
    }
}

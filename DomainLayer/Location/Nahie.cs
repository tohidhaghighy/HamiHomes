using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Location
{
    public class Nahie:BaseEntity<int>
    {
        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        [MinLength(3, ErrorMessage = "بیشتر از 3 کلمه باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsy { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(1000, ErrorMessage = "کمتر از 1000 کلمه باشد")]
        public string Icon { get; set; }


        public int CityId { get; set; }

        #region Foregnkey

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
        #endregion

        public virtual ICollection<Mahalle> Mahalles { get; set; }
    }
}

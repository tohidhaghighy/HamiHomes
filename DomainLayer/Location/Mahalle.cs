using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Location
{
    public class Mahalle:BaseEntity<int>
    {
        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsy { get; set; }

        public int NahieId { get; set; }

        #region Foregnkey

        [ForeignKey(nameof(NahieId))]
        public virtual Nahie Nahie { get; set; }
        #endregion
    }
}

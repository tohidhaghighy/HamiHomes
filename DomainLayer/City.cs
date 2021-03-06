﻿using DomainLayer.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer
{
    public class City:BaseEntity<int>
    {
        [Required(ErrorMessage ="نباید خالی باشد")]
        [MaxLength(50,ErrorMessage ="کمتر از 50 کلمه باید باشد")]
        [MinLength(3, ErrorMessage = "بیشتر از 3 کلمه باید باشد")]
        public string Name { get; set; }
        public int RegionId { get; set; }
        public string CityPhoneCode { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "کمتر از 50 کلمه باشد")]
        public string Gpsy { get; set; }
        public string Code { get; set; }

        #region Foregnkey

        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }
        #endregion

        public virtual ICollection<Nahie> Nahies { get; set; }

    }
}

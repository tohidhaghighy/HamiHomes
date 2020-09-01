﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Home
{
    public class Edari
    {
        [Key]
        public int Id { get; set; }

        public int MetrazhBena { get; set; }
        public int Tabaghe { get; set; }
        public int TedadOtagh { get; set; }
        public int Tedadkoltabaghat { get; set; }
        public int Tedadkolvahedha { get; set; }
        public int Tedadvaheddartabaghe { get; set; }


        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniName { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniPhone { get; set; }


        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homemogheiat { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homenema { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Hometasisat { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homekaf { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homewc { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homeparking { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homevaziate { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string HomeEmtiaz { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homesanad { get; set; }

        public int HomeId { get; set; }

        #region Foregnkey

        [ForeignKey(nameof(HomeId))]
        public virtual Home Home { get; set; }
        #endregion
    }
}

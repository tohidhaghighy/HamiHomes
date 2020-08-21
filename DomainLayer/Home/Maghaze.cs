using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Home
{
    public class Maghaze
    {
        [Key]
        public int Id { get; set; }

        public int MetrazhKafMaghaze { get; set; }
        public int DahaneMaghaze { get; set; }
        public int Tabaghe { get; set; }
        public int Metrazhbalkon { get; set; }
        public int Metrazhanbar { get; set; }


        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniName { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniPhone { get; set; }


        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homemogheiat { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homemoshakhase { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homewc { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homedivar { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homeparking { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homevaziatemelk { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string HomeEmtiaz { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homesanad { get; set; }

        public int HomeId { get; set; }

    }
}

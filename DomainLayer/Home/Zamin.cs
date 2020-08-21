﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Home
{
    public class Zamin
    {
        [Key]
        public int Id { get; set; }

        public int Metrazhzamin { get; set; }
        public int Arzegozar { get; set; }
        public int Arzemelk { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniName { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniPhone { get; set; }


        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homemogheiat { get; set; }
        
        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homevaziate { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string HomeEmtiaz { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Homesanad { get; set; }

        public int HomeId { get; set; }

    }
}
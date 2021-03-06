﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Utilities.Random;

namespace DomainLayer.Home
{
    public class TurkishHome:BaseEntity<int>
    {
        public TurkishHome()
        {
            this.IsShow = false;
            this.Date = DateTime.Now;
            this.Code = RandomNumber.GetRandomNumber().ToString();
        }

        [Required]
        [MaxLength(10, ErrorMessage = "نباید از 10 حرف بیشتر باشد")]
        public string Code { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(500, ErrorMessage = "نباید از 10 حرف بیشتر باشد")]
        public string Address { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(200, ErrorMessage = "نباید از 10 حرف بیشتر باشد")]
        public string Title { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public int BuildYear { get; set; }


        public int Bed { get; set; }
        public int Bath { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string HomeMapImage { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string ThreeDView { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Boolean IsShow { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نباید از 50 حرف بیشتر باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نباید از 50 حرف بیشتر باشد")]
        public string Gpsy { get; set; }


        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(200, ErrorMessage = "نباید از 200 حرف بیشتر باشد")]
        public string OwnerName { get; set; }

        [MaxLength(100, ErrorMessage = "نباید از 100 حرف بیشتر باشد")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(100, ErrorMessage = "نباید از 100 حرف بیشتر باشد")]
        public string Mobile { get; set; }

        public Boolean IsPrivate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Person:BaseEntity<int>
    {
        [Required(ErrorMessage ="نام نباید خالی باشد")]
        [MaxLength(50,ErrorMessage = "نام از 50 کلمه نباید بیشتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "نام خانوادگی نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نام خانوادگی از 50 کلمه نباید بیشتر باشد")]
        public string Family { get; set; }

        [Required(ErrorMessage = "نام کاربری نباید خالی باشد")]
        [MaxLength(100, ErrorMessage = "نام کاربری از 100 کلمه نباید بیشتر باشد")]
        [MinLength(6, ErrorMessage = "نام کاربری از 6 کلمه نباید کمتر باشد")]
        public string Username { get; set; }

        [Required(ErrorMessage = "پسورد نباید خالی باشد")]
        [MaxLength(500, ErrorMessage = "پسورد از 500 کلمه نباید بیشتر باشد")]
        [MinLength(6,ErrorMessage = "پسورد از 6 کلمه نباید کمتر باشد")]
        public string Password { get; set; }
    }
}

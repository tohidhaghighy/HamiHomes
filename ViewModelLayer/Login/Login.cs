using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModelLayer.Login
{
    public class Login
    {
        [Required(ErrorMessage ="نام کاربری نباید خالی باشد")]
        [MaxLength(50,ErrorMessage = "نام کاربری نباید از 50 حرف بیشتر باشد")]
        [MinLength(6,ErrorMessage = "نام کاربری نباید از 6 حرف کمتر باشد")]
        public string Username { get; set; }
        [Required(ErrorMessage = "پسورد نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "پسورد نباید از 50 حرف بیشتر باشد")]
        [MinLength(6, ErrorMessage = "طول نباید از  6 حرف کمتر باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Boolean RememberMe { get; set; }
    }
}

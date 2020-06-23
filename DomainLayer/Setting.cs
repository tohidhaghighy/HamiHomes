using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Setting:BaseEntity<int>
    {
        public Setting()
        {
            this.Aparat = "";
            this.Telegram = "";
            this.Instagram = "";
            this.Twitter = "";
            this.Googleplus = "";
            this.Youtube = "";
        }
        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Instagram { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Twitter { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Telegram { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Googleplus { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Aparat { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Youtube { get; set; }


        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Icon { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Title { get; set; }

        [MaxLength(1000, ErrorMessage = " از 1000 کلمه نباید بیشتر باشد")]
        public string Keys { get; set; }

        [MaxLength(500, ErrorMessage = " از 500 کلمه نباید بیشتر باشد")]
        public string Author { get; set; }

        [MaxLength(1000, ErrorMessage = " از 1000 کلمه نباید بیشتر باشد")]
        public string Description { get; set; }

        [MaxLength(100, ErrorMessage = " از 1000 کلمه نباید بیشتر باشد")]
        public string Phone { get; set; }

        [MaxLength(100, ErrorMessage = " از 1000 کلمه نباید بیشتر باشد")]
        public string Mobile { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Utilities.Calender;

namespace DomainLayer
{
    public class Magzine:BaseEntity<int>
    {
        public Magzine()
        {
            this.InsertDate = DateTime.Now;
            this.Date = Calender.OnlyPersianDate(DateTime.Now);
            Is_Show = false;
            Visit_Count = 0;
        }

        [Required(ErrorMessage ="نباید عنوان خالی باشد")]
        [MaxLength(100,ErrorMessage ="نباید طول عنوان از 100 کارکتر بیشتر باشد")]
        public string Title { get; set; }

        [Required(ErrorMessage = "نباید متن خالی باشد")]
        public string Text { get; set; }

        [Required(ErrorMessage = "نباید تاریخ خالی باشد")]
        [MaxLength(100, ErrorMessage = "نباید طول عنوان از 100 کارکتر بیشتر باشد")]
        public string Date { get; set; }

        [Required(ErrorMessage = "نباید تاریخ خالی باشد")]
        public DateTime InsertDate { get; set; }

        [MaxLength(500, ErrorMessage = "نباید طول ویدیو از 500 کارکتر بیشتر باشد")]
        public string Image { get; set; }

        public Boolean Is_Show { get; set; }
        public int Visit_Count { get; set; }

        [MaxLength(500, ErrorMessage = "نباید طول تگ ها از 500 کارکتر بیشتر باشد")]
        public string Tags { get; set; }

        [MaxLength(500, ErrorMessage = "نباید طول ویدیو از 500 کارکتر بیشتر باشد")]
        public string Video { get; set; }

        public int MagzineTypeId { get; set; }
        

        #region Foregnkey

        [ForeignKey(nameof(MagzineTypeId))]
        public virtual MagzineType MagzineType { get; set; }
        #endregion

    }
}

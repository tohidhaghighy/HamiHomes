using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Magzine
{
    public class Magazine:BaseEntity<int>
    {
        public Magazine()
        {
            this.ViewerCount = 0;
            this.Date = DateTime.Now;
        }

        [Required(ErrorMessage =" عنوان نباید خالی باشد")]
        [MaxLength(100,ErrorMessage ="نباید از 100 کارکتر بیشتر باشد")]
        public string Title { get; set; }

        [Required(ErrorMessage = " عنوان نباید خالی باشد")]
        public DateTime Date { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 کارکتر بیشتر باشد")]
        public string Image { get; set; }

        [Required(ErrorMessage = " عنوان نباید خالی باشد")]
        public string Text { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 کارکتر بیشتر باشد")]
        public string Tags { get; set; }
        public int ViewerCount { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 کارکتر بیشتر باشد")]
        public string UrlTour360 { get; set; }

        public int MagazinGroupId { get; set; }

        #region Foregnkey

        [ForeignKey(nameof(MagazinGroupId))]
        public virtual MagazinGroup MagazinGroup { get; set; }

        #endregion

    }
}

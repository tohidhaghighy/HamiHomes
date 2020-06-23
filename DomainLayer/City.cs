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

        #region Foregnkey
        
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }
        #endregion

    }
}

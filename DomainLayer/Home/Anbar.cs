using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Home
{
    public class Anbar
    {
        [Key]
        public int Id { get; set; }

        public int MetrazhBena { get; set; }
        public int Metrazhzamin { get; set; }

        public int Arzegozar { get; set; }
        public int Arzemelk { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniName { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string NegahbaniPhone { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string HomeEmtiaz { get; set; }
        public string SanadStatus { get; set; }
        public string MoghiateMelk { get; set; }

        public int HomeId { get; set; }


        #region Foregnkey

        [ForeignKey(nameof(HomeId))]
        public virtual Home Home { get; set; }
        #endregion


    }
}

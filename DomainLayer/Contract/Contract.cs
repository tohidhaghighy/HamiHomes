using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Contract
{
    public class Contract:BaseEntity<int>
    {
        public TypeHome TypContract { get; set; }
        public long SellCOst { get; set; }
        public long RentCOst { get; set; }
        public long Vadie { get; set; }
        public int Metraz { get; set; }
        public int HomeId { get; set; }
        public DateTime Date { get; set; }
        public Boolean SelledOrRented { get; set; }
        public Nullable<int> AdviserId { get; set; }

        [ForeignKey(nameof(HomeId))]
        public virtual Home.Home Home { get; set; }

        [ForeignKey(nameof(AdviserId))]
        public virtual Adviser Adviser { get; set; }

    }
}

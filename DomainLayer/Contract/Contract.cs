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
        public long BuyCost { get; set; }
        public long RentCOst { get; set; }
        public long Vadie { get; set; }
        public int Metraz { get; set; }
        public int MetrazZamin { get; set; }
        public int HomeId { get; set; }
        public DateTime Date { get; set; }
        public Nullable<long> FinalCost1 { get; set; }
        public Nullable<long> FinalCost2 { get; set; }
        public Nullable<long> FinalCost3 { get; set; }
        public Boolean SelledOrRented { get; set; }
        public Nullable<int> AdviserId { get; set; }
        public Nullable<int> CostumerId { get; set; }
        public DateTime SellDate { get; set; }
        public string GharardadNumber { get; set; }
        public string Description { get; set; }



        [ForeignKey(nameof(HomeId))]
        public virtual Home.Home Home { get; set; }

        [ForeignKey(nameof(AdviserId))]
        public virtual Adviser Adviser { get; set; }

    }
}

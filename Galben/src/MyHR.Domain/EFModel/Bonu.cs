namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bonu
    {
        [Key]
        public int BonusId { get; set; }

        public int EmployeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public decimal? BonusAmount { get; set; }

        public int CurrencyId { get; set; }

        public virtual SysCurrency SysCurrency { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

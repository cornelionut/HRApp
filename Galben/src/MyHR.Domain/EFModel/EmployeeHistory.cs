namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeHistory")]
    public partial class EmployeeHistory
    {
        public int EmployeeHistoryId { get; set; }

        public int EmployeeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(13)]
        public string PIN { get; set; }

        public int PositionId { get; set; }

        public int DepartmentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int StateId { get; set; }

        public int? ManagerId { get; set; }

        public int? ModifyById { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifyDate { get; set; }

        public int? AddressId { get; set; }
    }
}

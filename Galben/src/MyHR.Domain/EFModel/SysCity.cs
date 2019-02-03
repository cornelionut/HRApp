namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysCity")]
    public partial class SysCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysCity()
        {
            EmployeeAddresses = new HashSet<EmployeeAddress>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SysCityId { get; set; }

        [StringLength(200)]
        public string SysCityName { get; set; }

        public int SysCountyId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }

        public virtual SysCounty SysCounty { get; set; }
    }
}

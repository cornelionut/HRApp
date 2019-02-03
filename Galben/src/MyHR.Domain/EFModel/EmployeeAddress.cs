namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAddress")]
    public partial class EmployeeAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeAddress()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int AddressId { get; set; }

        public int SysCityId { get; set; }

        [StringLength(256)]
        public string StreetName { get; set; }

        [StringLength(50)]
        public string StreetNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual SysCity SysCity { get; set; }
    }
}

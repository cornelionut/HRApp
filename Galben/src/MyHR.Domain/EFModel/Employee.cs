namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Bonus = new HashSet<Bonu>();
            Salaries = new HashSet<Salary>();
            Employee1 = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(13)]
        public string PIN { get; set; }

        public int AddressId { get; set; }

        public int StateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime EmploymentDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        public int? ManagerId { get; set; }

        public int DepartmentId { get; set; }

        public int PositionId { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        public DateTime ModifiedOn { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bonu> Bonus { get; set; }

        public virtual SysDepartment SysDepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salary> Salaries { get; set; }

        public virtual EmployeeAddress EmployeeAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }

        public virtual SysPosition SysPosition { get; set; }

        public virtual SysState SysState { get; set; }
    }
}

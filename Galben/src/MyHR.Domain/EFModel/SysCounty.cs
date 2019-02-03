namespace MyHR.Domain.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysCounty")]
    public partial class SysCounty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysCounty()
        {
            SysCities = new HashSet<SysCity>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SysCountyId { get; set; }

        [StringLength(200)]
        public string SysCountyName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysCity> SysCities { get; set; }
    }
}

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MayTinh")]
    public partial class MayTinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MayTinh()
        {
            PhienSuDungs = new HashSet<PhienSuDung>();
        }

        [Key]
        public int MaMay { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMay { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        public DateTime? NgayThemMay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhienSuDung> PhienSuDungs { get; set; }
    }
}

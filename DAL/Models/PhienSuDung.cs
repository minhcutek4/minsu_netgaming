namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhienSuDung")]
    public partial class PhienSuDung
    {
        [Key]
        public int MaPhien { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaMay { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime? ThoiGianKetThuc { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual MayTinh MayTinh { get; set; }
    }
}

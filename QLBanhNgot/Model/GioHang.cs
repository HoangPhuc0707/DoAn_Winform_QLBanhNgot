namespace QLBanhNgot.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaBanh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenBanh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LoaiBanh { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiaTien { get; set; }
    }
}

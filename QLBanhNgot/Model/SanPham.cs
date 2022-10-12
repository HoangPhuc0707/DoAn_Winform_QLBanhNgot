namespace QLBanhNgot.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
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

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiaTien { get; set; }
    }
}

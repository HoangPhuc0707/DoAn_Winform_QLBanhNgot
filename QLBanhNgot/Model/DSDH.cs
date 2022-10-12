namespace QLBanhNgot.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSDH")]
    public partial class DSDH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TongTien { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ThoiGianBanRa { get; set; }
    }
}

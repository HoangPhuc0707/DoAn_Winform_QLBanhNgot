namespace QLBanhNgot.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbLogin : DbContext
    {
        public dbLogin()
            : base(@"Data Source=KEIJET\SQLEXPRESS;Initial Catalog=DoAnWinform;Integrated Security=True")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<DSDH> DSDHs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

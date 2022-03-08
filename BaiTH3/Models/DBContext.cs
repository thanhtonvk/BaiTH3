using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTH3.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<GiaBan> GiaBans { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.GiaBans)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHang>()
                .HasMany(e => e.HangHoas)
                .WithRequired(e => e.LoaiHang)
                .WillCascadeOnDelete(false);

     
        }
    }
}
using A_DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Context
{
    public class QL_LapTopContext : DbContext
    {
        public QL_LapTopContext() 
        {

        }
        public QL_LapTopContext(DbContextOptions options) : base(options)
        {
            
        }

        
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<Pin> Pins { get; set; }
        public DbSet<PhanLoai> PhanLoais { get; set; }

        public DbSet<ManHinh> ManHinhs  { get; set; }

        public DbSet<Ram> Rams  { get; set; }
        public DbSet<CardDoHoa> CardDoHoas { get; set; }
        public DbSet<OCung> OCungs { get; set; }
        public DbSet<Chip> Chips { get; set; }
        public DbSet<HinhAnh> HinhAnhs { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<DiemThuong> DiemThuongs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<LapTop> LapTops { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<LoaiHang> LoaiHangs { get; set; }
        public DbSet<LapTopCT> LapTopCTs { get; set; }
        public DbSet<SaleCT> SaleCTs { get; set; }
        public DbSet<HoaDonCT> hoaDonCTs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer(@"Data Source=LAPTOP-CXH2410\SQLEXPRESS;Initial Catalog=QL_LAPTOP_LAN3;Integrated Security=True"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có


            
        }

       
    }
}

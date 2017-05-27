namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebcafefilmDbContext : DbContext
    {
        public WebcafefilmDbContext()
            : base("name=WebcafefilmDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DetailMovie> DetailMovies { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieUser> MovieUsers { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<RatingOfMovie> RatingOfMovies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<PhimChuaKiemDuyet> PhimChuaKiemDuyets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.Domain)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.Hosting)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.MuaPhim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.BanPhim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.BaoTri)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.TongSoDu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.DoanhThus)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.IdEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.RatingOfMovies)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieUsers)
                .WithRequired(e => e.Movie)
                .HasForeignKey(e => e.IdMovie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.MovieUsers)
                .WithRequired(e => e.ThanhVien)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.RatingOfMovies)
                .WithRequired(e => e.ThanhVien)
                .WillCascadeOnDelete(false);
        }
    }
}

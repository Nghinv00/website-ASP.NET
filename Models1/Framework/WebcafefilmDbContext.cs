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
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<RatingOfMovie> RatingOfMovies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Categories)
                .Map(m => m.ToTable("CategoryOfMovie").MapLeftKey("CategoryID").MapRightKey("MovieID"));

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Account)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.RatingOfMovies)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.RatingOfMovies)
                .WithRequired(e => e.ThanhVien)
                .WillCascadeOnDelete(false);
        }
    }
}

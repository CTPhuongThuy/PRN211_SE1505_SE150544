using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class SE1505_EmployeeDepartmentContext : DbContext
    {
        public SE1505_EmployeeDepartmentContext()
        {
        }

        public SE1505_EmployeeDepartmentContext(DbContextOptions<SE1505_EmployeeDepartmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDb> AccountDbs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlServer("server =(local); database = SE1505_EmployeeDepartmen;uid=sa;pwd=07112001Thuy;TrustServerCertificate=True");
                optionsBuilder.UseSqlServer();

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountDb>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__AccountD__1788CCACA7E9757F");

                entity.ToTable("AccountDB");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.AccountFullName).HasMaxLength(100);

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(90);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(200);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__Depart__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

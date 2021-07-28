using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HousingLoans.Infrastructure.Persistence
{
    public partial class HosingLoansLab1DBContext : DbContext
    {
        public HosingLoansLab1DBContext()
        {
        }

        public HosingLoansLab1DBContext(DbContextOptions<HosingLoansLab1DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<HosingLoansDatum> HosingLoansData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HosingLoansLab1DB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Account");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CustomerDetail");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Aid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AID");

                entity.Property(e => e.ChtName).HasMaxLength(30);

                entity.Property(e => e.Education).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<HosingLoansDatum>(entity =>
            {
                entity.HasKey(e => e.LoansId);

                entity.Property(e => e.LoansId).HasColumnName("LoansID");

                entity.Property(e => e.AnnualIncome).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Borrower).HasMaxLength(30);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.HourseOwner).HasMaxLength(30);

                entity.Property(e => e.Industry).HasMaxLength(30);

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LoanUsage).HasMaxLength(50);

                entity.Property(e => e.LocationNow).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

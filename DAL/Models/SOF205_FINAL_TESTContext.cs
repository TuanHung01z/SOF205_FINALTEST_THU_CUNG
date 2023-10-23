using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class SOF205_FINAL_TESTContext : DbContext
    {
        public SOF205_FINAL_TESTContext()
        {
        }

        public SOF205_FINAL_TESTContext(DbContextOptions<SOF205_FINAL_TESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chunhan> Chunhans { get; set; } = null!;
        public virtual DbSet<Cuahang> Cuahangs { get; set; } = null!;
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; } = null!;
        public virtual DbSet<Phuhuynh> Phuhuynhs { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Sinhvien> Sinhviens { get; set; } = null!;
        public virtual DbSet<Thucung> Thucungs { get; set; } = null!;
        public virtual DbSet<Trungtam> Trungtams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-L8JJAL6;Database=SOF205_FINAL_TEST;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chunhan>(entity =>
            {
                entity.ToTable("CHUNHAN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Cuahang>(entity =>
            {
                entity.ToTable("CUAHANG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Loaihang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("loaihang");

                entity.Property(e => e.Mota)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mota");

                entity.Property(e => e.Ngaydangky)
                    .HasColumnType("date")
                    .HasColumnName("ngaydangky");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Cuahangs)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FKCH_TT");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Phuhuynh>(entity =>
            {
                entity.ToTable("PHUHUYNH");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nghenghiep)
                    .HasMaxLength(50)
                    .HasColumnName("nghenghiep");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.ToTable("SANPHAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.IdNcc).HasColumnName("idNCC");

                entity.Property(e => e.Mota)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mota");

                entity.Property(e => e.Soluongtonkho).HasColumnName("soluongtonkho");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdNccNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.IdNcc)
                    .HasConstraintName("FK_SP_NCC");
            });

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.ToTable("SINHVIEN");

                entity.HasIndex(e => e.Email, "UQ__SINHVIEN__AB6E61640C49D30A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdPh).HasColumnName("idPH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdPhNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.IdPh)
                    .HasConstraintName("FK_SV_PH");
            });

            modelBuilder.Entity<Thucung>(entity =>
            {
                entity.ToTable("THUCUNG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Loai)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("loai");

                entity.Property(e => e.Maulong)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maulong");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.Property(e => e.Tuoi).HasColumnName("tuoi");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Thucungs)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FK_TC_CN");
            });

            modelBuilder.Entity<Trungtam>(entity =>
            {
                entity.ToTable("TRUNGTAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

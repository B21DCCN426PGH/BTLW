using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ABCD_OnlineMall.Models
{
    public partial class mallDBContext : DbContext
    {
        public mallDBContext()
        {
        }

        public mallDBContext(DbContextOptions<mallDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Plot> Plots { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog =mallDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admins");

                entity.Property(e => e.AdminId).HasColumnName("adminId");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminName");

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminPassword");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brands");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brandName");

                entity.Property(e => e.BrandUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brandURL");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imageName");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__brands__storeId__2E1BDC42");
            });


            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("feedbackId");

                entity.Property(e => e.FeedbackContent)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("feedbackContent");

                entity.Property(e => e.FeedbackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("feedbackDate");

                entity.Property(e => e.FeedbackSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feedbackSubject");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");
            });


            modelBuilder.Entity<Plot>(entity =>
            {
                entity.ToTable("plots");

                entity.Property(e => e.PlotId).HasColumnName("plotId");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.IsEmpty).HasColumnName("isEmpty");

                entity.Property(e => e.PlotName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plotName");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Plots)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__plots__storeId__2F10007B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imageName");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__products__brandI__300424B4");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__products__storeI__30F848ED");
            });


            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("stores");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.CloseTime).HasColumnName("closeTime");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imageName");

                entity.Property(e => e.OpenTime).HasColumnName("openTime");

                entity.Property(e => e.PlotId).HasColumnName("plotId");

                entity.Property(e => e.PromoImageName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("promoImageName");

                entity.Property(e => e.StoreAbout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeAbout");

                entity.Property(e => e.StoreCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeCategory");

                entity.Property(e => e.StoreDescription)
                    .HasColumnType("text")
                    .HasColumnName("storeDescription");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeName");

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.PlotId)
                    .HasConstraintName("FK__stores__plotId__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public partial class MLLJK_VictoriaContext : DbContext
    {
        public MLLJK_VictoriaContext()
        {
        }

        public MLLJK_VictoriaContext(DbContextOptions<MLLJK_VictoriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<TodoItems> TodoItems { get; set; }
        public virtual DbSet<TodoLists> TodoLists { get; set; }
        public virtual DbSet<Vsbrand> Vsbrand { get; set; }
        public virtual DbSet<Vscategory> Vscategory { get; set; }
        public virtual DbSet<Vscolor> Vscolor { get; set; }
        public virtual DbSet<Vsindex> Vsindex { get; set; }
        public virtual DbSet<Vsproduct> Vsproduct { get; set; }
        public virtual DbSet<VsproductColor> VsproductColor { get; set; }
        public virtual DbSet<VsproductPrice> VsproductPrice { get; set; }
        public virtual DbSet<VsproductReview> VsproductReview { get; set; }
        public virtual DbSet<VsproductSearchIndex> VsproductSearchIndex { get; set; }
        public virtual DbSet<VsproductSize> VsproductSize { get; set; }
        public virtual DbSet<Vsretailer> Vsretailer { get; set; }
        public virtual DbSet<Vssize> Vssize { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=mlljksqlserver.database.windows.net;Database=MLLJK_Victoria;Trusted_Connection=False;MultipleActiveResultSets=true;User Id=adminadmin;Password=Victoria21;Integrated Security=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.DeviceCode)
                    .IsUnique();

                entity.HasIndex(e => e.Expiration);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TodoItems>(entity =>
            {
                entity.HasIndex(e => e.ListId);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.List)
                    .WithMany(p => p.TodoItems)
                    .HasForeignKey(d => d.ListId);
            });

            modelBuilder.Entity<TodoLists>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Vsbrand>(entity =>
            {
                entity.ToTable("VSBrand");

                entity.Property(e => e.BrandName).HasMaxLength(50);
            });

            modelBuilder.Entity<Vscategory>(entity =>
            {
                entity.ToTable("VSCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(150);
            });

            modelBuilder.Entity<Vscolor>(entity =>
            {
                entity.ToTable("VSColor");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ColorName).HasMaxLength(110);
            });

            modelBuilder.Entity<Vsindex>(entity =>
            {
                entity.HasKey(e => e.FakeId);

                entity.ToTable("VSIndex");

                entity.Property(e => e.BrandName).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(150);

                entity.Property(e => e.ColorName).HasMaxLength(110);

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.ImageUrl).HasMaxLength(400);

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.SizeName).HasMaxLength(20);
            });

            modelBuilder.Entity<Vsproduct>(entity =>
            {
                entity.ToTable("VSProduct");

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.ImageUrl).HasMaxLength(350);

                entity.Property(e => e.ProductName).HasMaxLength(150);

                entity.Property(e => e.ProductUrl).HasMaxLength(350);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Vsproduct)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_VSProduct_VSBrand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Vsproduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_VSProduct_VSCategory");
            });

            modelBuilder.Entity<VsproductColor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ColorId });

                entity.ToTable("VSProductColor");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.VsproductColor)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FK_VSProductColor_VSColor");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.VsproductColor)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSProductColor_VSProduct");
            });

            modelBuilder.Entity<VsproductPrice>(entity =>
            {
                entity.ToTable("VSProductPrice");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.VsproductPrice)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_VSProductPriceAndReview_VSColor");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.VsproductPrice)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_VSProductPriceAndReview_VSProduct");

                entity.HasOne(d => d.Retailer)
                    .WithMany(p => p.VsproductPrice)
                    .HasForeignKey(d => d.RetailerId)
                    .HasConstraintName("FK_VSProductPriceAndReview_VSRetailer");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.VsproductPrice)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_VSProductPriceAndReview_VSSize");
            });

            modelBuilder.Entity<VsproductReview>(entity =>
            {
                entity.ToTable("VSProductReview");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.VsproductReview)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_VSProductReview_VSColor");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.VsproductReview)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_VSProductReview_VSProduct");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.VsproductReview)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_VSProductReview_VSSize");
            });

            modelBuilder.Entity<VsproductSearchIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VSProductSearchIndex");

                entity.Property(e => e.BrandName).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(150);

                entity.Property(e => e.ColorName).HasMaxLength(110);

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.ImageUrl).HasMaxLength(381);

                entity.Property(e => e.ProductName).HasMaxLength(282);

                entity.Property(e => e.SizeName).HasMaxLength(20);
            });

            modelBuilder.Entity<VsproductSize>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.SizeId });

                entity.ToTable("VSProductSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.VsproductSize)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSProductSize_VSProduct");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.VsproductSize)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSProductSize_VSSize");
            });

            modelBuilder.Entity<Vsretailer>(entity =>
            {
                entity.ToTable("VSRetailer");

                entity.Property(e => e.RetailerName).HasMaxLength(50);
            });

            modelBuilder.Entity<Vssize>(entity =>
            {
                entity.ToTable("VSSize");

                entity.Property(e => e.SizeName).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

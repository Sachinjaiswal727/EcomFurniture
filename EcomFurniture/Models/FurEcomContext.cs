using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcomFurniture.Models
{
    public partial class FurEcomContext : DbContext
    {
        public FurEcomContext()
        {
        }

        public FurEcomContext(DbContextOptions<FurEcomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contactu> Contactus { get; set; }
        public virtual DbSet<Custorder> Custorders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3EJ1KVH\\SQLEXPRESS;Database=FurEcom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__Category__213EE774A4B7767C");

                entity.ToTable("Category");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("c_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("c_name");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contactus");

                entity.Property(e => e.ContactusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("contactus_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Custorder>(entity =>
            {
                entity.HasKey(e => e.OId)
                    .HasName("PK__custorde__904BC20E431E739E");

                entity.ToTable("custorder");

                entity.Property(e => e.OId).HasColumnName("o_id");

                entity.Property(e => e.ODate)
                    .HasColumnType("date")
                    .HasColumnName("o_date");

                entity.Property(e => e.OFinalprice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("o_finalprice");

                entity.Property(e => e.OQuantity).HasColumnName("o_quantity");

                entity.Property(e => e.OStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("o_status");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.UId).HasColumnName("u_id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Product__82E06B917E0A67D3");

                entity.ToTable("Product");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("img_url");

                entity.Property(e => e.PCategory).HasColumnName("p_category");

                entity.Property(e => e.PDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("p_description");

                entity.Property(e => e.PDiscount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("p_discount");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("p_price");

                entity.HasOne(d => d.PCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__p_categ__70DDC3D8");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("PK__roles__C4762327B310BB47");

                entity.ToTable("roles");

                entity.Property(e => e.RId)
                    .ValueGeneratedNever()
                    .HasColumnName("r_id");

                entity.Property(e => e.Role1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__users__B51D3DEA84324135");

                entity.ToTable("users");

                entity.HasIndex(e => e.UEmail, "UQ__users__3DF9EF222572186D")
                    .IsUnique();

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.Property(e => e.UAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("u_address");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("u_email");

                entity.Property(e => e.ULastname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("u_Lastname");

                entity.Property(e => e.UMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_mobile");

                entity.Property(e => e.UName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("u_name");

                entity.Property(e => e.UPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("u_password");

                entity.Property(e => e.UPinCode).HasColumnName("u_PinCode");

                entity.Property(e => e.URole).HasColumnName("u_role");

                entity.HasOne(d => d.URoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.URole)
                    .HasConstraintName("FK__users__u_role__7F2BE32F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

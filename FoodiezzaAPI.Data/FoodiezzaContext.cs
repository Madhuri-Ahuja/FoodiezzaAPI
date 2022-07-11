using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodiezzaAPI.Data
{
    public partial class FoodiezzaContext : DbContext
    {
        public FoodiezzaContext()
        {
        }

        public FoodiezzaContext(DbContextOptions<FoodiezzaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BillingDetails> BillingDetails { get; set; }
        public virtual DbSet<FoodInfo> FoodInfo { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Foodiezza;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingDetails>(entity =>
            {
                entity.HasKey(e => e.BillingId)
                    .HasName("PK__Billing___3767155F92A2922A");

                entity.ToTable("Billing_Details");

                entity.Property(e => e.BillingId).HasColumnName("Billing_Id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal)
                    .HasColumnName("Sub_Total")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("Zip_Code")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.BillingDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Billing_D__Order__32E0915F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BillingDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Billing_D__User___31EC6D26");
            });

            modelBuilder.Entity<FoodInfo>(entity =>
            {
                entity.HasKey(e => e.FoodId)
                    .HasName("PK__Food_Inf__2F4C4DD82D5E2193");

                entity.ToTable("Food_Info");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CookTime)
                    .HasColumnName("cook_time")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasColumnName("food_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FoodQuantity)
                    .HasColumnName("foodQuantity")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("image_url")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Rating).HasColumnName("rating");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Order_De__F1E4607B4A0AC9A1");

                entity.ToTable("Order_Details");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.SubTotal)
                    .HasColumnName("Sub_Total")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("FK__Order_Det__food___2E1BDC42");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Order_Det__User___2F10007B");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__User_Tab__206D9170D31C1637");

                entity.ToTable("User_Table");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__User_Tab__A9D1053463617306")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

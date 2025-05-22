using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RESO.Entities;

namespace RESO.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderWithDetailsView> OrderWithDetailsViews { get; set; }

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<GetBill> GetOrderBill { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var constr = configuration.GetSection("constr").Value;

        optionsBuilder.UseSqlServer(constr);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Orders", schema: "Sales");
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC071836EEBC");

            entity.Property(e => e.OrderDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("OrderDetails", schema: "Sales");
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC07F1181A53");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Order__3D5E1FD2");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Produ__3E52440B");
        });

        modelBuilder.Entity<OrderWithDetailsView>(entity =>
        {
            entity.ToView("OrderWithDetailsView");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Products", schema: "Inventory");
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC0797207A38");
        });
        modelBuilder.Entity<GetBill>()
            .ToFunction("GetOrderBill")
            .HasNoKey();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

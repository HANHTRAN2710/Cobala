using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cobala.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Buoihoc> Buoihocs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Chuongtrinhhoc> Chuongtrinhhocs { get; set; }

    public virtual DbSet<Tintuc> Tintucs { get; set; }

    public virtual DbSet<Vechungtoi> Vechungtois { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-EHPMEAT\\SQLEXPRESS;Database=DemoCobala;user id=sa;password=1;trusted_connection=true;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Buoihoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__buoihoc__3214EC0761C06AB3");

            entity.ToTable("buoihoc");

            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Name).HasColumnType("ntext");
            entity.Property(e => e.Timed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__category__3214EC07BE4DB2D5");

            entity.ToTable("category");

            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Chuongtrinhhoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__chuongtr__3214EC071E961ECB");

            entity.ToTable("chuongtrinhhoc");

            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Name).HasMaxLength(1000);
            entity.Property(e => e.Photo)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.Chuongtrinhhocs)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chuongtri__Categ__398D8EEE");
        });

        modelBuilder.Entity<Tintuc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tintuc__3214EC071A7D2212");

            entity.ToTable("tintuc");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(1000);
            entity.Property(e => e.Photo)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vechungtoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vechungt__3214EC072F3FE57A");

            entity.ToTable("vechungtoi");

            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Name).HasColumnType("ntext");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

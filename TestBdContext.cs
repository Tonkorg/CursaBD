using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CursaBD;

public partial class TestBdContext : DbContext
{
    public TestBdContext()
    {
    }

    public TestBdContext(DbContextOptions<TestBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Home> Homes { get; set; }

    public virtual DbSet<Otr> Otrs { get; set; }

    public virtual DbSet<Sen> Sens { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=F:\\\\\\\\TestBd.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(e => e.ChildrenId);

            entity.HasIndex(e => e.ChildrenId, "IX_Children_ChildrenId").IsUnique();

            entity.Property(e => e.Age).HasColumnType("NUMERIC");

            entity.Property(e => e.Otr).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");
            entity.HasIndex(e => e.EmployeeId, "IX_Emploeyee_EmploeyeeId").IsUnique();
            entity.HasKey(e => e.EmployeeId);
        });

        modelBuilder.Entity<Home>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Home");

            entity.HasIndex(e => e.Number, "IX_Home_Number").IsUnique();
        });

        modelBuilder.Entity<Otr>(entity =>
        {
            entity.HasKey(e => e.Number);

            entity.ToTable("Otr");

            entity.HasIndex(e => e.Number, "IX_Otr_Number").IsUnique();

            entity.Property(e => e.Number).ValueGeneratedNever();
        });

        modelBuilder.Entity<Sen>(entity =>
        {
            entity.HasKey(e => e.TypeSens);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Login, "IX_User_Login").IsUnique();

            entity.HasIndex(e => e.UserId, "IX_User_UserId").IsUnique();

            entity.Property(e => e.UserType).HasDefaultValueSql("1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

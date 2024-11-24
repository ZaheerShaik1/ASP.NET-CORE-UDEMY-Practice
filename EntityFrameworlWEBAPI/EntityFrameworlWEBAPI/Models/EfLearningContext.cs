using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworlWEBAPI.Models;

public partial class EfLearningContext : DbContext
{
    public EfLearningContext()
    {
    }

    public EfLearningContext(DbContextOptions<EfLearningContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=EfLearningDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__course__37E309C3C4C4503D");

            entity.ToTable("course");

            entity.Property(e => e.CourseId)
                .ValueGeneratedNever()
                .HasColumnName("Course_id");
            entity.Property(e => e.CourseCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Course_category");
            entity.Property(e => e.CourseName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("course_name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__student__3213E83F411FB2BB");

            entity.ToTable("student");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

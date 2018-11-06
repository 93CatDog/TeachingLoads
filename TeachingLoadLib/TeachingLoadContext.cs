using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TeachingLoadCore
{
    public partial class TeachingLoadContext : DbContext
    {
        //public TeachingLoadContext()
        //{
        //}

        public TeachingLoadContext(DbContextOptions<TeachingLoadContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClassTypes> ClassTypes { get; set; }
        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<DisciplinesGroups> DisciplinesGroups { get; set; }
        public virtual DbSet<DisciplinesTeachers> DisciplinesTeachers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Datasource=D:\\\\pojects\\\\TeachingLoad\\\\TeachingLoads\\\\TeachingLoadLib\\\\TeachingLoad.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassTypes>(entity =>
            {
                entity.HasIndex(e => e.DisciplineId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Disciplines>(entity =>
            {
                entity.HasIndex(e => e.ClassTypeId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EducationForm).HasDefaultValueSql("'Денна'");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DisciplinesGroups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DisciplinesTeachers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EducationForm)
                    .IsRequired()
                    .HasDefaultValueSql("'Денна'");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Degree).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Post).IsRequired();

                entity.Property(e => e.Rank).IsRequired();
            });
        }
    }
}

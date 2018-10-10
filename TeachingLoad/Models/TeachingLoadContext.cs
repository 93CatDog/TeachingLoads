using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TeachingLoadLib.Entities;

namespace TeachingLoad.Models
{
    public partial class TeachingLoadContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        public TeachingLoadContext()
        {
        }

        public TeachingLoadContext(DbContextOptions<TeachingLoadContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Datasource=D:\\pojects\\TeachingLoad\\TeachingLoads\\TeachingLoad\\TeachingLoad.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}

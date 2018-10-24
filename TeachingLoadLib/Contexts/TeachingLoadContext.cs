using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TeachingLoadCore.Entities;

namespace TeachingLoadCore.Contexts
{
    public partial class TeachingLoadContext : DbContext
    {
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<DisciplineTeacher> DisciplinesTeachers { get; set; }
        public DbSet<DisciplineGroup> DisciplinesGroups { get; set; }

        public TeachingLoadContext()
        {
            Task<int> disciplinesTask = Disciplines.CountAsync();

            Task<int> teachersTask = Teachers.CountAsync();
            
            Task<int> groupsTask = Groups.CountAsync();

            Task<int> disciplinesTeachersTask = DisciplinesTeachers.CountAsync();

            Task<int> disciplinesGroupsTask = DisciplinesGroups.CountAsync();

            Task<int> classTypesTask = ClassTypes.CountAsync();

            Discipline.Count = disciplinesTask.Result;
            Teacher.Count = teachersTask.Result;
            Group.Count = groupsTask.Result;
            ClassType.Count = classTypesTask.Result;
            DisciplineTeacher.Count = disciplinesTeachersTask.Result;
            DisciplineGroup.Count = disciplinesGroupsTask.Result;
        }

        //public TeachingLoadContext(DbContextOptions<TeachingLoadContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Datasource=D:\\pojects\\TeachingLoad\\TeachingLoads\\TeachingLoadLib\\TeachingLoad.db");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadCore.Entities
{
    [Table("Groups")]
    public class Group
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Course")]
        public Int64 Course { get; set; }

        [Column("EducationForm")]
        public String EducationForm { get; set; }

        [Column("TuitionFreeStudents")]
        public Int64 TuitionFreeStudents { get; set; }

        [Column("ContractedStudents")]
        public Int64 ContractedStudents { get; set; }

        [Column("Annotation")]
        public string Annotation { get; set; }

        public static int Count { get; set; }

        public Group(String name, int course, String educationform, int tuitionFreeStudents, int contractedStudents, String annotation)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
            this.Course = course;
            this.EducationForm = educationform;
            this.TuitionFreeStudents = tuitionFreeStudents;
            this.ContractedStudents = contractedStudents;
            this.Annotation = annotation;
        }

        public Group()
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

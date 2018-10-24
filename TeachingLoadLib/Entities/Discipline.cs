using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadCore.Entities
{
    [Table("Disciplines")]
    public class Discipline
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Annotation")]
        public string Annotation { get; set; }

        [Column("Course")]
        public Int64 Course { get; set; }

        [Column("EducationForm")]
        public String EducationForm { get; set; }

        [Column("Amount")]
        public Double Amount { get; set; }

        [Column("ClassTypeId")]
        public Int64 ClassTypeId { get; set; }



        public static int Count { get; set; }

        public Discipline(String name, int course, String educationForm, double amount, String annotation)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
            this.Course = course;
            this.EducationForm = educationForm;
            this.Amount = amount;
            this.Annotation = annotation;
        }

        public Discipline(String name, String annotation)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
            this.Annotation = annotation;
        }

        public Discipline()
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

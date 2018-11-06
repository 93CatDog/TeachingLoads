using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace TeachingLoadCore
{
    public partial class Disciplines
    {
        public static int Count { get; set; }

        public Disciplines(String name, int course, String educationForm, double amount, String annotation)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
            this.Course = course;
            this.EducationForm = educationForm;
            this.Amount = amount;
            this.Annotation = annotation;
        }

        public Disciplines(String name, String annotation)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
            this.Annotation = annotation;
        }

    }
}

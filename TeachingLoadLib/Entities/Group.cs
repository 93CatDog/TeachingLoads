using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadCore
{
    public partial class Groups
    {
        public static int Count { get; set; }

        public Groups(String name, int course, String educationform, int tuitionFreeStudents, int contractedStudents, String annotation)
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

        public Groups()
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

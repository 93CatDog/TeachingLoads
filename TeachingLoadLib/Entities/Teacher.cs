using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadCore
{
    public partial class Teachers
    {
        public static int Count { get; set; }

        public Teachers(String firstName, String lastName, String patronymic, String post, String rank, String degree, String annotation)
        {
            Count++;
            this.Id = Count;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronymic = patronymic;
            this.Post = post;
            this.Rank = rank;
            this.Degree = degree;
            this.Annotation = annotation;
        }
    }
}

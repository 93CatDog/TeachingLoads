﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadLib.Entities
{
    //public int Id { get; set; }
    //public String FirstName { get; set; }
    //public String LastName { get; set; }
    //public String Patronymic { get; set; }
    //public Degree Degree { get; set; }

    [Table("Teachers")]
    public class Teacher
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }

        //[Column("Annotation")]
        //public string Annotation { get; set; }

        public static int Count { get; set; }

        public Teacher(String firstName, String lastName, String patronymic)
        {
            Count++;
            this.Id = Count;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronymic = patronymic;
        }

        public Teacher()
        {

        }

        public override string ToString()
        {
            return this.LastName;
        }
    }
}

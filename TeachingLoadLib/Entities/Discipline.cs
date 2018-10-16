using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadLib.Entities
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

        public static int Count { get; set; }

        public Discipline(String name)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
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

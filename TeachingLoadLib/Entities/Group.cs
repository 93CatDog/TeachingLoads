using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingLoadLib.Entities
{
    [Table("Groups")]
    public class Group
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Annotation")]
        public string Annotation { get; set; }

        public static int Count { get; set; }

        public Group(String name)
        {
            Count++;
            this.Id = Count;
            this.Name = name;
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeachingLoadCore.Entities
{
    [Table("DisciplinesTeachers")]
    public partial class DisciplineTeacher
    {
        [Column("Id")]
        [Key]
        public Int64 Id { get; set; }

        [Column("DisciplineId")]
        public Int64 DisciplineId { get; set; }

        [Column("TeacherId")]
        public Int64 TeacherId { get; set; }

        public static int Count { get; set; }

        public DisciplineTeacher()
        {
            Count++;
        }

    }
}

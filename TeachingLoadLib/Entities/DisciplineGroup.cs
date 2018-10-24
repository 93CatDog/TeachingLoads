using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeachingLoadCore.Entities
{
    [Table("DisciplinesGroups")]
    public partial class DisciplineGroup
    {
        [Column("Id")]
        [Key]
        public Int64 Id { get; set; }

        [Column("DisciplineId")]
        public Int64 DisciplineId { get; set; }

        [Column("GroupId")]
        public Int64 GroupId { get; set; }

        public static int Count { get; set; }

        public DisciplineGroup()
        {
            Count++;
        }
    }
}

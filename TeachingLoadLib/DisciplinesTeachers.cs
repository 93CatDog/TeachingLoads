using System;
using System.Collections.Generic;

namespace TeachingLoadCore
{
    public partial class DisciplinesTeachers
    {
        public long Id { get; set; }
        public long DisciplineId { get; set; }
        public long TeacherId { get; set; }
    }
}

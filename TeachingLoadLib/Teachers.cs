using System;
using System.Collections.Generic;

namespace TeachingLoadCore
{
    public partial class Teachers
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Post { get; set; }
        public string Rank { get; set; }
        public string Degree { get; set; }
        public string Annotation { get; set; }
        public long? WorkLoad { get; set; }
    }
}

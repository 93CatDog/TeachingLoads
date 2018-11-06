using System;
using System.Collections.Generic;

namespace TeachingLoadCore
{
    public partial class Disciplines
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Course { get; set; }
        public string EducationForm { get; set; }
        public double? Amount { get; set; }
        public long? ClassTypeId { get; set; }
        public string Annotation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TeachingLoadCore
{
    public partial class Groups
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Course { get; set; }
        public string EducationForm { get; set; }
        public long TuitionFreeStudents { get; set; }
        public long ContractedStudents { get; set; }
        public string Annotation { get; set; }
    }
}

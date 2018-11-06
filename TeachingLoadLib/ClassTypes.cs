using System;
using System.Collections.Generic;

namespace TeachingLoadCore
{
    public partial class ClassTypes
    {
        public long Id { get; set; }
        public double Lectures { get; set; }
        public double LaboratoryWorks { get; set; }
        public double PracticeWorks { get; set; }
        public double Exams { get; set; }
        public double FinalTests { get; set; }
        public double Tests { get; set; }
        public double HomeTests { get; set; }
        public double Consultations { get; set; }
        public double CalculationWorks { get; set; }
        public double DesignWorks { get; set; }
        public double MasterWorks { get; set; }
        public double? ManagingOfPractises { get; set; }
        public double? ManagingOfVerifications { get; set; }
        public double? MasterReports { get; set; }
        public double? VerificationReviews { get; set; }
        public long DisciplineId { get; set; }
    }
}

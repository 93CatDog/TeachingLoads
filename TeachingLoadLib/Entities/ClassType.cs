using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeachingLoadCore.Entities
{
    [Table("ClassTypes")]
    public partial class ClassType
    {
        [Column("Id")]
        [Key]
        public Int64 Id { get; set; }
        [Column("Lectures")]
        public Double Lectures { get; set; }
        [Column("LaboratoryWorks")]
        public Double LaboratoryWorks { get; set; }
        [Column("PracticeWorks")]
        public Double PracticeWorks { get; set; }
        [Column("Exams")]
        public Double Exams { get; set; }
        [Column("FinalTests")]
        public Double FinalTests { get; set; }
        [Column("Tests")]
        public Double Tests { get; set; }
        [Column("HomeTests")]
        public Double HomeTests { get; set; }
        [Column("Consultations")]
        public Double Consultations { get; set; }
        [Column("CalculationWorks")]
        public Double CalculationWorks { get; set; }
        [Column("DesignWorks")]
        public Double DesignWorks { get; set; }
        [Column("MasterWorks")]
        public Double MasterWorks { get; set; }
        [Column("ManagingOfPractises")]
        public Double? ManagingOfPractises { get; set; }
        [Column("ManagingOfVerifications")]
        public Double? ManagingOfVerifications { get; set; }
        [Column("MasterReports")]
        public Double? MasterReports { get; set; }
        [Column("VerificationReviews")]
        public Double? VerificationReviews { get; set; }
        [Column("DisciplineId")]
        public Int64 DisciplineId { get; set; }

        public static int Count { get; set; }

        public ClassType()
        {
            Count++;
        }
    }
}

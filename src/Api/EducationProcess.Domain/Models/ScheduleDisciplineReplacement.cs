﻿using System;
using System.Collections.Generic;


namespace EducationProcess.Domain.Models

{
    public partial class ScheduleDisciplineReplacement
    {

        public int ScheduleDisciplineReplacementId { get; set; }
        public int? ScheduleDisciplineId { get; set; }
        public int FixedDisciplineId { get; set; }
        public DateTime Date { get; set; }
        public int PairNumber { get; set; }
        public int? AudienceId { get; set; }
        public bool? IsFirstSubgroup { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedByEmployeeId { get; set; }
        public DateTime ModifiedAt { get; set; }

        public  Audience Audience { get; set; }
        public  Employee CreatedByEmployee { get; set; }
        public  FixedDiscipline FixedDiscipline { get; set; }
        public  Employee ModifiedByEmployee { get; set; }
        public  ScheduleDiscipline ScheduleDiscipline { get; set; }
        public List<ConductedPair> ConductedPairs { get; set; }
    }
}
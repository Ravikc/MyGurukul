using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public enum Level { UG, PG };
    public enum Stream { Engineering , Architecture };

    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Level DepartmentLevel { get; set; } //UG or PG
        public Stream Stream { get; set; } //Engg. or Architecture

        public List<CourseOutcome> CourseOutcomes { get; set; }
        public List<ProgramOutcome> ProgramOutcomes { get; set; }
    }
}

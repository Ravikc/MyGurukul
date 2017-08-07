using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public enum CourseType { Core, Elective };

    public class CurrentSubject
    {
        public int CurrentSubjectID { get; set; }
        public int Semester { get; set; }
        public DateTime StartDate { get; set; }
        public int Credits { get; set; }
        public CourseType CourseType { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }

        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }        
    }
}

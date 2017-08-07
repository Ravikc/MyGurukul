using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public DateTime Date { get; set; }

        public int? StudentID { get; set; }
        public Student Student { get; set; }

        public int CurrentSubjectID { get; set; }
        public CurrentSubject CurrentSubject { get; set; }        
    }
}

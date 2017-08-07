using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public class Result
    {
        public int ResultID { get; set; }
        public int Marks { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamName { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int CurrentSubjectID { get; set; }
        public CurrentSubject CurrentSubject { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public class MentorAllotment
    {
        public int ID { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }
    }
}

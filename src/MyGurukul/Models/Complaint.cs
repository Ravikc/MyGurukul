using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public class Complaint
    {
        public int ComplaintID { get; set; }
        public string Content { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}

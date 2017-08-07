using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public class TimeTable
    {
        public int TimeTableID { get; set; }
        //using int to measure time elasped since midnight, mins = dd%60, hours = dd/60        
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public int CurrentSubjectID { get; set; }
        public CurrentSubject CurrentSubject { get; set; }
    }
}

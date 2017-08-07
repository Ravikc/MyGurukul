using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyGurukul.Models
{
    public enum Section { A, B, C, D, E, F, G, H };
    
    public class Student
    {
        public int StudentId { get; set; }      
        public int CurrentSemester { get; set; }      
        public string USN { get; set; }
        public Section Section { get; set; }
              
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
    }
}

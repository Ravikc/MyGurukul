using System;

namespace MyGurukul.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        


        //reference key to the use table
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
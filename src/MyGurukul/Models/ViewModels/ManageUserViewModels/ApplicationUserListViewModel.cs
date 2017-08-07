using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models.ViewModels.ManageUserViewModels
{
    public class ApplicationUserListViewModel
    {
        [Display(Name = "User Email Address")]
        public string UserEmail { get; set; }
        public string UserID { get; set; }

        public  IList<string> Roles { get; set; }
    }
}

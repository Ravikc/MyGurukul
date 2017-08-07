using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models.ViewModels.ManageUserViewModels
{
    public class ApplicationUserDetailsViewModel
    {
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Joining Date")]
        public DateTime JoinDate { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Department { get; set; }

        [Display(Name = "Role")]
        public IList<string> Roles { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models.ViewModels
{
    public class ApplicationRoleListViewModel
    {
        public string ID { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public string Description { get; set; }        
    }
}

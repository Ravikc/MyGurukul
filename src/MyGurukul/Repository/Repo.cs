using Microsoft.AspNetCore.Identity;
using MyGurukul.Data;
using MyGurukul.Models;
using MyGurukul.Models.ViewModels.ManageUserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Repository
{
    public class Repo
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;
        public Repo(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;    
        }

        public async Task<ApplicationUserDetailsViewModel> GetUserDetails(ApplicationUser user)
        {
            var result = new ApplicationUserDetailsViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.Lastname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                JoinDate = user.JoinDate,
                Roles = await _userManager.GetRolesAsync(user)
            };

            return result;
        }
    }
}

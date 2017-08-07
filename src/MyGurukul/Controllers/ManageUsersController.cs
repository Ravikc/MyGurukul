using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MyGurukul.Models;
using MyGurukul.Models.ViewModels.ManageUserViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGurukul.Repository;
using MyGurukul.Data;

namespace MyGurukul.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;          

        public ManageUsersController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _db = context;      
        }

        public async Task<IActionResult> Index(string filterParameter = null)
        {
            filterParameter = string.IsNullOrEmpty(filterParameter) ? "Student" : filterParameter;
            List<ApplicationUserListViewModel> list = new List<ApplicationUserListViewModel>();
            IList<String> role = null;
            foreach (var user in _userManager.Users.ToList())
            {
                role = await _userManager.GetRolesAsync(user);

                if (role.Contains(filterParameter))
                {
                    list.Add(new ApplicationUserListViewModel()
                    {
                        UserID = user.Id,
                        UserEmail = user.Email,
                        Roles = role
                    });
                }
            }
            return View(list);
        }

        public async Task<IActionResult> DeleteUser(string userID)
        {
            var user = await _userManager.FindByIdAsync(userID);
            var routeValue = new List<string>( await _userManager.GetRolesAsync(user));
            if (user != null)
                await _userManager.DeleteAsync(user);
            return RedirectToAction("Index", new { filterParameter = routeValue[0] });
        }

        public async Task<IActionResult> EditAndViewUserDetails(string userID, string whatToDo)
        {
            var user = await _userManager.FindByIdAsync(userID);
            if (whatToDo.Equals("View"))
                return View("ViewUserDetails", await new Repo(_userManager, _db).GetUserDetails(user));

            return View("EditUserDetails", await new Repo(_userManager, _db).GetUserDetails(user));
        }

        [HttpPost]
        public IActionResult EditUserDetails(ApplicationUserDetailsViewModel vm)
        {
            return View("ViewUserDetails", vm);
        }


    }
}
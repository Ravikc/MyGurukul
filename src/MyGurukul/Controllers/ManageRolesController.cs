using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MyGurukul.Models;
using MyGurukul.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace MyGurukul.Controllers
{    
    public class ManageRolesController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public ManageRolesController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            List<ApplicationRoleListViewModel> model = new List<ApplicationRoleListViewModel>();
            model = _roleManager.Roles.Select(r => new ApplicationRoleListViewModel
            {
                ID = r.Id,
                RoleName = r.Name,               
                Description = r.Description               
            }).ToList();
            return View(model);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(ApplicationRoleListViewModel vm)
        {
            if (ModelState.IsValid)
            {
                bool roleExist = await _roleManager.RoleExistsAsync(vm.RoleName);
                if (roleExist)
                    return RedirectToAction("CreateRole");

                ApplicationRole role = new ApplicationRole() { Name = vm.RoleName, Description = vm.Description };
                await _roleManager.CreateAsync(role);
            }
            return RedirectToAction("Index");
        }

        

        [HttpGet]
        [Authorize(Roles="Super User")]
        public async Task<IActionResult> DeleteRole(string ID)
        {
            if (ID == null)
                return RedirectToAction("Index");

            var role = await _roleManager.FindByIdAsync(ID);
            
            IdentityResult result =  _roleManager.DeleteAsync(role).Result;
            if (result.Succeeded)
                return RedirectToAction("Index");

            return RedirectToAction("CreateRole");
        }

        [HttpGet]        
        public IActionResult EditRole(string Id, string name,  string description)
        {
            return View(new ApplicationRoleListViewModel() { ID = Id, Description = description, RoleName = name });
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(ApplicationRoleListViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(vm.ID);

                role.Description = vm.Description;
                role.Name = vm.RoleName;

                IdentityResult result =  await _roleManager.UpdateAsync(role);
                if(result.Succeeded)
                    return RedirectToAction("Index");
            }
            return RedirectToAction("EditRole", new { Id = vm.ID, name = vm.RoleName, description = vm.Description });  
        }

    }
}
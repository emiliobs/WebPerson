using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebPerson.Models
{
    public class UsersRoles
    {
        public List<SelectListItem> userRoles;

        public UsersRoles()
        {
            userRoles = new List<SelectListItem>();
        }

        public List<SelectListItem> GetRoles(RoleManager<IdentityRole>  roleManager)
        {
            var roles = roleManager.Roles.ToList().OrderBy(r => r.Name);

            foreach (var data in roles)
            {
                userRoles.Add(new SelectListItem()
                {
                    Value = data.Id,
                    Text = data.Name
                });
            }

            return userRoles;
        }
    }
}

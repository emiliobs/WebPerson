using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPerson.Data;

namespace WebPerson.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        #region Attributes

        private UsersRoles usersRoles;
        #endregion

        #region Properties
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Permisos")]
        [UIHint("List")]
        public List<SelectListItem> Roles { get; set; }

        [Required]
        public string Role { get; set; }

        #endregion
        #region Constructor
        public RegisterViewModel()
        {
            Roles = new List<SelectListItem>();
            usersRoles = new UsersRoles();

            //proceso estatico
            //Roles.Add(new SelectListItem()
            //{
            //    Value = "1",
            //    Text = "Admin"
            //});

            //Roles.Add(new SelectListItem()
            //{
            //    Value = "2",
            //    Text = "User"
            //});




        }

        #endregion
        #region Methods
        public void GetRoles(RoleManager<IdentityRole> roleManager )
        {
            this.Roles = usersRoles.GetRoles(roleManager);
        }
        #endregion

    }
}

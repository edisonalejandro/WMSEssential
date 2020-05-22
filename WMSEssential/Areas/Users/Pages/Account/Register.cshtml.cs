using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WMSEssential.Areas.Users.Models;
using WMSEssential.Library;

namespace WMSEssential.Areas.Users.Pages.Acounnt
{
    public class RegisterModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager; //Objetos de la clase SignManager que guarda los registros de cada usuario
        private UserManager<IdentityUser> _userManager;     //Objetos de la clase userManager que guarda los registros de cada usuario
        private RoleManager<IdentityRole> _roleManager;     //Objetos de la clase roleManager que guarda los roles
        private LUserRoles _usersRole;
        //metodo constructor
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _usersRole = new LUserRoles();
        }
        public void OnGet()
        {
            Input = new InputModel
            {
                rolesLista = _usersRole.getRoles(_roleManager)
            };
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel: InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            [TempData]
            public string ErrorMessage { get; set; }

            public List<SelectListItem> rolesLista { get; set; }
        }
    }
}

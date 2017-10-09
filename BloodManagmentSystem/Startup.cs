using BloodManagmentSystem.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloodManagmentSystem.Startup))]

namespace BloodManagmentSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole {Name = "Admin"};
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "crappylime@op.pl",
                    Email = "crappylime@op.pl"
                };

                string userPwd = "Vamp@admin0";

                var chkUser = userManager.Create(user, userPwd);

                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("RCK"))
            {
                var role = new IdentityRole {Name = "RCK"};
                roleManager.Create(role);
            }
        }
    }
}
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NCMS.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCMS.Startup))]
namespace NCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        // In this method we will create default User roles and Admin user for login    
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User     
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool    
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.FirstName = "Akinbamidele";
                user.LastName = "Akinmejiwa";
                user.PhoneNumber = "09080086100";
                user.UserName = "admin@admin.com";
                user.Email = "admin@admin.com";

                string userPWD = "Admin123@";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Doctor role     
            if (!roleManager.RoleExists("Doctor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Doctor";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.FirstName = "Chucks";
                user.LastName = "Chukwuma";
                user.PhoneNumber = "0801234567890";
                user.UserName = "doctor@doctor.com";
                user.Email = "doctor@doctor.com";

                string userPWD = "Doctor123@";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Doctor");

                }

            }

            // creating Creating Pharmacist role     
            if (!roleManager.RoleExists("Pharmacist"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Pharmacist";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.FirstName = "Nkiru";
                user.LastName = "Ayoola";
                user.PhoneNumber = "0901234567890";
                user.UserName = "pharma@pharma.com";
                user.Email = "pharma@pharma.com";

                string userPWD = "Pharmacist123@";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Pharmacist");

                }

            }

            // creating Creating Pharmacist role     
            if (!roleManager.RoleExists("Nurse"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Nurse";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.FirstName = "Aishat";
                user.LastName = "Malik";
                user.PhoneNumber = "0701234567890";
                user.UserName = "nurse@nurse.com";
                user.Email = "nurse@nurse.com";

                string userPWD = "Nurse123@";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Nurse");

                }

            }

            // creating Creating Front Desk role     
            if (!roleManager.RoleExists("Front Desk"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Front Desk";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.FirstName = "Ajibade";
                user.LastName = "Blessing";
                user.PhoneNumber = "0601234567890";
                user.UserName = "frontdesk@frontdesk.com";
                user.Email = "frontdesk@frontdesk.com";

                string userPWD = "FrontDesk123@";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Front Desk");

                }

            }
            // creating Creating Patient role     
            if (!roleManager.RoleExists("Patient"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Patient";
                roleManager.Create(role);



            }
        }
    }
}

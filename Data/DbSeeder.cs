using System;
using Microsoft.AspNetCore.Identity;
using ZHotelMenuAndOrder.Constants;

namespace ZHotelMenuAndOrder.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Chef.ToString()));
           
            // creating admin

            var user = new ApplicationUser
            {
                UserName = "Zadmin",
                Email = "admin@gmail.com",
                Name = "Abebe",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
               
            }
            // creating chef

            var chef = new ApplicationUser
            {
                UserName = "Zchef",
                Email = "chef@gmail.com",
                Name = "kebede",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var chefInDb = await userManager.FindByEmailAsync(chef.Email);
            if (chefInDb == null)
            {
                await userManager.CreateAsync(chef, "Chef@123");
                await userManager.AddToRoleAsync(chef, Roles.Chef.ToString());

            }
            
        }

    }
}

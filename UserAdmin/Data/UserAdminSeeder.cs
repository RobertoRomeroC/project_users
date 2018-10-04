using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAdmin.Data.Entities;

namespace UserAdmin.Data
{
    public class UserAdminSeeder
    {
        private readonly UserAdminContext _ctx;

        public UserAdminSeeder(UserAdminContext ctx)
        {
            _ctx = ctx;
        }

        public static void Seed(UserAdminContext context)
        {          
            if (context.Users.Any())
            {
                return;
            }
            var users = new User[]
            {
            new User{Mail="ro@gmail.com", Users="Carson", Password = "ThisTest123!", Status= true, Sex = "Male"},
            new User{Mail="pete@gmail.com", Users="Peter", Password = "ThisTest1234!", Status= true, Sex = "Male"}            
            };

            foreach (User u in users)
            {
                context.Users.Add(u);
            } 
            context.SaveChanges();
        }
    }
}

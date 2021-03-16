using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            SignUpDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<SignUpDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        GroupName = "2-3 IS Core",
                        GroupSize = 4,
                        EmailAddress = "somethingsmart@junkmail.com",
                        PhoneNumber = 5555555555
                    },

                    new Project
                    {
                        GroupName = "2-4 IS Core",
                        GroupSize = 4,
                        EmailAddress = "SignUp@junkmail.com",
                        PhoneNumber = 5555555556
                    },

                    new Project
                    {
                        GroupName = "2-5 IS Core",
                        GroupSize = 4,
                        EmailAddress = "GetMeAnA@junkmail.com",
                        PhoneNumber = 5555555557
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

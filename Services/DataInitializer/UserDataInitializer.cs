﻿using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Services.DataInitializer
{
    public class UserDataInitializer : IDataInitializer
    {
        private readonly UserManager<User> userManager;

        public UserDataInitializer(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public void InitializeData()
        {
            if (!userManager.Users.AsNoTracking().Any(p => p.UserName == "Admin"))
            {
                var user = new User
                {
                    Age = 25,
                    FullName = ""
                    Gender = GenderType.Female,
                    UserName = "admin",
                    Email = "admin@site.com"
                };
                var result = userManager.CreateAsync(user, "123456").GetAwaiter().GetResult();
            }
        }
    }
}

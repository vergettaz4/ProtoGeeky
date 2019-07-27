﻿namespace Geeky.Web.Helpers
{
    using Geeky.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Threading.Tasks;
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;

        public UserHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await this.userManager.FindByEmailAsync(email);
            return user;
        }
    }
}


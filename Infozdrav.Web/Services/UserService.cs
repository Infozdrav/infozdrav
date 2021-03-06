﻿using System.Linq;
using Infozdrav.Web.Abstractions;
using Infozdrav.Web.Data;
using Infozdrav.Web.Data.Manage;

namespace Infozdrav.Web.Services
{
    public class UserService : IDependency
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CheckEmail(User user, string newMail, out string error)
        {
            error = "";

            // Email already in use
            if (_dbContext.Users.Any(u => u.Id != user.Id && u.Email == newMail))
            {
                error = "Email already in use!";
                return false;
            }

            return true;
        }
    }
}
using GpodawundTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GpodawundTwo.Services
{
    public class UserService
    {
        // Vaporware for demo.  Any email and password will return the same user .... James Walker
        // SCR TODO -  Dabase with web service to create users/roles (MVC or Angular single page app)
        public User GetUserByCredentials(string email, string password)
        {
            //  SCR Not hooking up a database right this instant.  A single user will be OK for testing.  
            User user = new User() { Id = "1", Email = "KindlyVet@AcmeAnimalClinic.com", Password = "beagle1", Name = "James Walker" };
            if (user != null)
            {
                // SCR Needless to say, we do not return passwords up the pipeline so we strip it here before returning.
                user.Password = string.Empty;
            }
            return user;
        }
    }
}
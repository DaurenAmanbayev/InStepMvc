using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using InStep.Models.Interfaces;
using InStep.Helpers;
using System.Security.Principal;

namespace InStep.Models
{
    public class UserPrincipal : IUserPrincipal,IPrincipal
    {
        [Required]
        public string Email { get; set; }
    
        public IIdentity Identity { get; private set; }

        public UserPrincipal() { }

        public UserPrincipal(string email)
        {
            Identity = new GenericIdentity(email);
        }



        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
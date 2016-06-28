using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InStep.Models.Interfaces
{
    public interface IUserPrincipal
    {
        string Email { get; set; }
    }
}
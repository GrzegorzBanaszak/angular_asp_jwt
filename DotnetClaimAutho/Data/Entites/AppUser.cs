using Microsoft.AspNetCore.Identity;
using System;

namespace DotnetClaimAutho.Data.Entites
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}

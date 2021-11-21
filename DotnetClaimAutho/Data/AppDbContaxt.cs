using DotnetClaimAutho.Data.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetClaimAutho.Data
{
    public class AppDbContaxt : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public AppDbContaxt(DbContextOptions options) : base(options)
        {
        }
    }
}

using DotnetClaimAutho.BindingModels;
using DotnetClaimAutho.Data.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetClaimAutho.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signmanage;

        public UserController(UserManager<AppUser> userManager,SignInManager<AppUser> signManage)
        {
            _userManager = userManager;
            _signmanage = signManage;
        }


        [HttpPost("RegisterUser")]
        public async Task<object> RegisterUser([FromBody] AddUpdateRegisterUserBindingModel model)
        {
            try
            {
                var user = new AppUser()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return await Task.FromResult("User has been Registered");
                }

                return await Task.FromResult(string.Join(",", result.Errors.Select(x => x.Description.ToArray())));
            }
            catch (Exception exe)
            {
                return await Task.FromResult(exe.Message);
            }
        }
    }
}

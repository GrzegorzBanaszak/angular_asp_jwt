using System;

namespace DotnetClaimAutho.DTO
{
    public class UserDto
    {

        public UserDto(string fullName,string email,string userName,DateTime dateCreated,DateTime dateUpdate)
        {
            FullName = fullName;
            Email = email;
            UserName = userName;
            DateCreated = dateCreated;
            DateUpdate = dateUpdate;
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; }

    }
}   

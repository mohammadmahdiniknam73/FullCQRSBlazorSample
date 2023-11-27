using Domain.Entities.Products;
using Domain.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Users
{
    public class User
    {
        public UserId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SirName { get; set; } = string.Empty;


        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public bool IsAvailable { get; set; }
        public DateOnly DateCreated { get; set; }
        public TimeOnly TimeCreated { get; set; }

        public Role Role { get; set; }
        
    }
}

using Domain.Entities.Orders;
using Domain.Entities.Roles;


namespace Domain.Entities.Users
{
    public class User
    {
        public UserId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string SirName { get; private set; } = string.Empty;


        public string UserName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;

        public bool IsAvailable { get; private set; }
        public DateOnly DateCreated { get; private set; }
        public TimeOnly TimeCreated { get; private set; }

        public Role Role { get; private set; }
        public ICollection<Order> Orders { get; set; }
    }
}

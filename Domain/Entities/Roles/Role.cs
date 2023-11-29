using Domain.Entities.Users;

namespace Domain.Entities.Roles
{
    public class Role 
    {
        public Role(RoleId id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public RoleId Id { get; private set; }
        public string RoleName { get; private set; } = string.Empty;

        public ICollection<User> Users { get; private set; }

    }
}

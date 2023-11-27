﻿using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Roles
{
    public class Role
    {
        public RoleId Id { get; set; }
        public string RoleName { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; }

    }
}
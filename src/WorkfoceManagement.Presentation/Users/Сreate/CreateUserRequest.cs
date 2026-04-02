using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkfoceManagement.Presentation.Users.Сreate
{
    public sealed class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WorkfoceManagement.Presentation.Console.Users.Create
{
    public sealed class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}

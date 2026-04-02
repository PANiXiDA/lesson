using System.Collections.Generic;

using WorkfoceManagement.Application.Users.Abstractions;
using WorkfoceManagement.Domain.Users;

namespace WorkfoceManagement.Infrastructure.Users
{
    public sealed class UsersRepository : IUsersRepository
    {
        private readonly Dictionary<string, User> _users;

        public UsersRepository()
        {
            _users = new Dictionary<string, User>();
        }

        public void Add(User user)
        {
            _users.Add(user.Email, user);
        }

        public User GetByEmail(string email)
        {
            return _users.GetValueOrDefault(email);
        }
    }
}

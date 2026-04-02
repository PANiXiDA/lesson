using WorkfoceManagement.Domain.Users;

namespace WorkfoceManagement.Application.Users.Abstractions
{
    public interface IUsersRepository
    {
        public void Add(User user);
        public User GetByEmail(string email);
    }
}

using WorkfoceManagement.Application.Users.Abstractions;
using WorkfoceManagement.Domain.Users;

namespace WorkfoceManagement.Application.Users.GetByEmail
{
    public sealed class GetUserByEmailHandler
    {
        private readonly IUsersRepository _usersRepository;

        public GetUserByEmailHandler(
            IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public User Handle(GetUserByEmailQuery query)
        {
            return _usersRepository.GetByEmail(query.Email);
        }
    }
}

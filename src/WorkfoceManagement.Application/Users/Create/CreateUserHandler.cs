using WorkfoceManagement.Application.Users.Abstractions;
using WorkfoceManagement.Domain.Users;

namespace WorkfoceManagement.Application.Users.Create
{
    public sealed class CreateUserHandler
    {
        private readonly IUsersRepository _usersRepository;

        public CreateUserHandler(
            IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Handle(CreateUserCommand command)
        {
            var user = User.Create(
                name: command.Name,
                email: command.Email,
                password: command.Password,
                age: command.Age);

            _usersRepository.Add(user);
        }
    }
}

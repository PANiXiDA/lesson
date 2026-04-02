using System;
using System.Collections.Generic;
using System.Text;
using WorkfoceManagement.Application.Users.Abstractions;
using WorkfoceManagement.Application.Users.Create;

namespace WorkfoceManagement.Presentation.Console.Users.Create
{
    public sealed class CreateUserHandler
    {
        private readonly WorkfoceManagement.Application.Users.Create.CreateUserHandler _createUserHandler;

        public CreateUserHandler(IUsersRepository usersRepository)
        {
            _createUserHandler = new WorkfoceManagement.Application.Users.Create.CreateUserHandler(usersRepository);
        }

        public void Create(CreateUserRequest request)
        {
            var command = new CreateUserCommand()
            {
                Name = request.Name,
                Email = request.Email,
                Age = request.Age,
                Password = request.Password,
            };

            _createUserHandler.Handle(command);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WorkfoceManagement.Application.Users.Abstractions;
using WorkfoceManagement.Application.Users.GetByEmail;

namespace WorkfoceManagement.Presentation.Console.Users.GetByEmail
{
    public sealed class GetByEmailUserHandler
    {
        private readonly WorkfoceManagement.Application.Users.GetByEmail.GetUserByEmailHandler _getByEmailUserHandler;

        public GetByEmailUserHandler(IUsersRepository usersRepository)
        {
            _getByEmailUserHandler = new WorkfoceManagement.Application.Users.GetByEmail.GetUserByEmailHandler(usersRepository);
        }

        public GetByEmailUserResponse GetByEmail(GetByEmailUserRequest request)
        {
            var query = new GetUserByEmailQuery()
            {
                Email = request.Email,
            };
            var user = _getByEmailUserHandler.Handle(query);

            var response = new GetByEmailUserResponse()
            {
                Age = user.Age,
                Email = user.Email,
                Name = user.Name,
            };

            return response;
        }
    }
}

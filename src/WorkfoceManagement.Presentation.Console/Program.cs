using System;
using WorkfoceManagement.Infrastructure.Users;
using WorkfoceManagement.Presentation.Console.Users.Create;
using WorkfoceManagement.Presentation.Console.Users.GetByEmail;

namespace WorkfoceManagement.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new UsersRepository();
            var createUserHandler = new CreateUserHandler(repository);
            var createUserRequest = new CreateUserRequest()
            {
                Age = 20,
                Name = "test",
                Email = "test@gmail.com",
                Password = "test1234"
            };

            createUserHandler.Create(createUserRequest);

            var getByEmailUserHandler = new GetByEmailUserHandler(repository);
            var getByEmailUserRequest = new GetByEmailUserRequest()
            {
                Email = "test@gmail.com"
            };

            var user = getByEmailUserHandler.GetByEmail(getByEmailUserRequest);
            System.Console.WriteLine(user);
            System.Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(user));
        }
    }
}

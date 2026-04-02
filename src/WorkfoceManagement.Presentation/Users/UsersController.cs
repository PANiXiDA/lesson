using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WorkfoceManagement.Application.Users.Create;
using WorkfoceManagement.Application.Users.GetByEmail;
using WorkfoceManagement.Infrastructure.Users;
using WorkfoceManagement.Presentation.Users.GetByEmail;
using WorkfoceManagement.Presentation.Users.Сreate;

namespace WorkfoceManagement.Presentation.Users
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private static UsersRepository _usersRepository = new UsersRepository();
        private static CreateUserHandler _createUserHandler = new CreateUserHandler(_usersRepository);
        private static GetUserByEmailHandler _getUserByEmailHandler = new GetUserByEmailHandler(_usersRepository);

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            var command = new CreateUserCommand()
            {
                Name = request.Name,
                Email = request.Email,
                Age = request.Age,
                Password = request.Password,
            };

            _createUserHandler.Handle(command);

            return Ok();
        }

        [HttpGet]
        public ActionResult<GetByEmailUserResponse> GetByEmail([FromQuery] GetByEmailUserRequest request)
        {
            var query = new GetUserByEmailQuery()
            {
                Email = request.Email
            };

            var user = _getUserByEmailHandler.Handle(query);
            var response = new GetByEmailUserResponse()
            {
                Age = user.Age,
                Email = user.Email,
                Name = user.Name,
            };

            return Ok(response);
        }
    }
}

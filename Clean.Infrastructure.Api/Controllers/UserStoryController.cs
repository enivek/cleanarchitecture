using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Infrastructure.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserStoryController : ControllerBase, Application.UseCase.AddUserStory.IOutputPort
    {

        private readonly ILogger<UserStoryController> _logger;

        private IActionResult _actionResult;

        public UserStoryController(ILogger<UserStoryController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AddUserStory(
            [FromServices] Application.UseCase.AddUserStory.IAddUserStoryUseCase useCase,
            Application.UseCase.AddUserStory.AddUserStoryCommand command)
        {
            useCase.SetOutputPort(this);
            useCase.Execute(command);
            return _actionResult;
        }

        void Application.UseCase.AddUserStory.IOutputPort.Ok()
        {
            _actionResult = Ok();
        }

        void Application.UseCase.AddUserStory.IOutputPort.Error()
        {
            _actionResult = new StatusCodeResult(500);
        }

    }
}

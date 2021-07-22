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
        public void AddUserStory(UserStory userStory)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public IEnumerable<UserStory> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
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

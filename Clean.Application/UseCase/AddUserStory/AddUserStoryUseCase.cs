using Clean.Application.Repository;
using Clean.Domain.Model;
using System;

namespace Clean.Application.UseCase.AddUserStory
{
    public class AddUserStoryUseCase : IAddUserStoryUseCase
    {
        private IUserStoryRepository _repository;
        private IOutputPort _outputPort;

        public AddUserStoryUseCase(IUserStoryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException();
        }

        public void SetOutputPort(IOutputPort outputPort)
        {
            _outputPort = outputPort ?? throw new ArgumentNullException();
        }

        public void Execute(AddUserStoryCommand command)
        {
            try
            {
                var id = new UserStoryId();
                var userStory = new UserStory(id);
                userStory.Text = command.Text;
                userStory.Title = command.Title;
                _repository.InsertOrUpdate(userStory);
                _outputPort.Ok();
            }
            catch (Exception ex)
            {
                _outputPort.Error();
            }
        }
    }
}

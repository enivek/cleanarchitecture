using Clean.Application.Repository;
using Clean.Domain.Model;
using System;

namespace Clean.Application.UseCase.EditUserStory
{
    public class EditUserStoryUseCase : IEditUserStoryUseCase
    {
        private IUserStoryRepository _repository;
        private IOutputPort _outputPort;

        public EditUserStoryUseCase(IUserStoryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException();
        }

        public void SetOutputPort(IOutputPort outputPort)
        {
            _outputPort = outputPort ?? throw new ArgumentNullException();
        }

        public void Execute( EditUserStoryCommand command )
        {
            try
            {
                var id = new UserStoryId(command.Id);
                var userStory = _repository.GetById(id);
                if (userStory == null)
                {
                    _outputPort.NotFound();
                }
                else
                {
                    userStory.Text = command.Text;
                    userStory.Title = command.Title;
                    _repository.InsertOrUpdate(userStory);
                    _outputPort.Ok();
                }
            }
            catch ( Exception ex )
            {
                _outputPort.Error();
            }
        }
    }
}

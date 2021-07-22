namespace Clean.Application.UseCase.AddUserStory
{
    public interface IAddUserStoryUseCase
    {
        void Execute(AddUserStoryCommand command);

        void SetOutputPort(IOutputPort outputPort);
    }
}

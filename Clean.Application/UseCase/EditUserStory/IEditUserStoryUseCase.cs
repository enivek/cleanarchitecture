namespace Clean.Application.UseCase.EditUserStory
{
    public interface IEditUserStoryUseCase
    {
        void Execute(EditUserStoryCommand command);

        void SetOutputPort(IOutputPort outputPort);
    }
}

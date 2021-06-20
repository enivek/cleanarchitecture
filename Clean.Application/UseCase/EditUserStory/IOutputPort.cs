namespace Clean.Application.UseCase.EditUserStory
{
    public interface IOutputPort
    {
        void Ok();

        void NotFound();

        void Error();
    }
}

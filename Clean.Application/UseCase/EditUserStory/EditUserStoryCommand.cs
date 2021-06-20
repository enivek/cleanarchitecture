namespace Clean.Application.UseCase.EditUserStory
{
    public class EditUserStoryCommand
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Text { get; set; }
    }
}

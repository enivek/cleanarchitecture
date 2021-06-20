using System.Collections.Generic;

namespace Clean.Application.Query
{
    public interface ISearchUserStoryQuery
    {
        IEnumerable<UserStory> Search(string searchString);
    }
}

using System.Collections.Generic;

namespace Clean.Application.Finder
{
    public interface IGetUserStoriesFinder
    {
        public IEnumerable<GetUserStoriesDto> GetUserStoriesByUserId(int userId);
    }

    public class GetUserStoriesDto
    {

    }
}

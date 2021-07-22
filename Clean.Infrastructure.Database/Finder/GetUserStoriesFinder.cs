using Clean.Application.Finder;
using System.Collections.Generic;

namespace Clean.Infrastructure.Database.Finder
{
    public class GetUserStoriesFinder : IGetUserStoriesFinder
    {
        public IEnumerable<GetUserStoriesDto> GetUserStoriesByUserId(int userId)
        {
            // Implement me
            throw new System.NotImplementedException();
        }
    }
}

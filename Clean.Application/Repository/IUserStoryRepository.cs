using Clean.Domain.Model;

namespace Clean.Application.Repository
{
    public interface IUserStoryRepository : IGenericRepository<UserStoryId, UserStory>
    {
    }
}

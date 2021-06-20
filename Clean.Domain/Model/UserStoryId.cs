using Clean.Domain.Common;

namespace Clean.Domain.Model
{
    public class UserStoryId : UniqueId
    {
        public UserStoryId() : base(0) { }

        public UserStoryId(int value) : base(value) { }
    }
}

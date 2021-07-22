using Clean.Domain.Common;

namespace Clean.Domain.Model
{
    public class UserId : UniqueId
    {
        public UserId() : base(0) { }

        public UserId(int value) : base(value) { }
    }
}

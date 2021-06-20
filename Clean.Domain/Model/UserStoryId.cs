using Clean.Domain.Common;

namespace Clean.Domain.Model
{
    public class UseCaseId : UniqueId
    {
        public UseCaseId() : base(0) { }

        public UseCaseId(int value) : base(value) { }
    }
}

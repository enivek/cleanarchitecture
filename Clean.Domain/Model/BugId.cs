using Clean.Domain.Common;

namespace Clean.Domain.Model
{
    public class BugId : UniqueId
    {
        public BugId() : base(0) { }

        public BugId(int value) : base(value) { }
    }
}

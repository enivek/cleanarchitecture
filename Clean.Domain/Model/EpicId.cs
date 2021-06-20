using Clean.Domain.Common;

namespace Clean.Domain.Model
{
    public class EpicId : UniqueId
    {
        public EpicId() : base(0) { }

        public EpicId(int value) : base(value) { }
    }
}

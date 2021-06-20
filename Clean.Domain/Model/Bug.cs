using Clean.Domain.Common;
using Clean.Domain.Guard;
using System;

namespace Clean.Domain.Model
{
    public class Bug : Entity
    {
        private BugId _bugId;

        public Bug(BugId bugId, string title)
        {
            StringGuard.AssertStringValid(title, 20, "title");
            Title = title;
            _bugId = bugId ?? throw new ArgumentNullException();
        }

        public string Title { get; private set; }
        public Priority BugPriority { get; private set; }

        public override UniqueId GetId()
        {
            return _bugId;
        }
    }
}

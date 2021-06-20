using Clean.Domain.Common;
using Clean.Domain.Guard;
using System;

namespace Clean.Domain.Model
{
    public class UserStory : Aggregate
    {
        private UserStoryId _id;
        private string _title;
        private string _text;

        public UserStory(UserStoryId id)
        {
            _id = id ?? throw new ArgumentNullException();
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                StringGuard.AssertStringValid(value, 2, 20, "title");
                _title = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                StringGuard.AssertStringValid(value, 2, 500, "text");
                _text = value;
            }
        }

        public override UniqueId GetId()
        {
            return _id;
        }
    }
}

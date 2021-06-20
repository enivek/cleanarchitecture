using Clean.Domain.Common;
using System;
using System.Collections.Generic;

namespace Clean.Domain.Common
{
    public class UniqueId : ValueObject
    {
        private int _id;

        public UniqueId(int id)
        {
            if (id < 0) throw new ArgumentException("id");
            _id = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _id;
        }
    }
}

using Clean.Domain.Common;
using System;
using System.Collections.Generic;

namespace Clean.Domain.Model
{
    public sealed class Priority : ValueObject
    {
        public string _value;

        private Priority(string value)
        {
            this._value = value ?? throw new ArgumentNullException();
        }

        public static Priority High = new Priority("H");
        public static Priority Medium = new Priority("M");
        public static Priority Low = new Priority("L");

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _value;
        }
    }
}
 
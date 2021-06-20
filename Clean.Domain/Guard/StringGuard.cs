using System;

namespace Clean.Domain.Guard
{
    public static class StringGuard
    {
        public static bool IsStringNullOrValid(string value, int minLength, int maxLength)
        {
            if (value != null)
            {
                if (value.Length < minLength)
                {
                    return false;
                }
                if (value.Length > maxLength)
                {
                    return false;
                }
            }
            return true;
        }

        public static void AssertStringNullOrValid(string value, int minLength, int maxLength, string propertyName)
        {
            if (value != null)
            {
                if (value.Length < minLength)
                {
                    throw new ArgumentException(propertyName + " is too short");
                }
                if (value.Length > maxLength)
                {
                    throw new ArgumentException(propertyName + " is too long");
                }
            }
        }

        public static bool IsStringValid(string value, int minLength, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            if (value.Length < minLength)
            {
                return false;
            }
            if (value.Length > maxLength)
            {
                return false;
            }
            return true;
        }

        public static void AssertStringValid(string value, int minLength, int maxLength, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(propertyName + " cannot be blank");
            }
            if (value.Length < minLength)
            {
                throw new ArgumentException(propertyName + " is too short");
            }
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName + " is too long");
            }
        }

        public static bool IsStringValid(string value, int length)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            if (value.Length != length)
            {
                return false;
            }
            return true;
        }

        public static void AssertStringValid(string value, int length, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(propertyName + " cannot be blank");
            }
            if (value.Length != length)
            {
                throw new ArgumentException(propertyName + " is not equal to " + length);
            }
        }
    }
}

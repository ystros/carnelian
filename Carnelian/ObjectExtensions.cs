using System;

namespace Carnelian
{
    public static class ObjectExtensions
    {
        public static TResult Try<TValue, TResult>(this TValue value, Func<TValue, TResult> method) where TValue : class
        {
            return value == null ? default(TResult) : method(value);
        }

        public static bool IsNull<TValue>(this TValue value) where TValue : class
        {
            return value == null;
        }

        public static bool IsPresent<TValue>(this TValue value) where TValue : class
        {
            return value != null;
        }
    }
}

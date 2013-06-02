using System;

namespace Carnelian
{
    public static class ObjectExtensions
    {
        public static TResult Try<TValue, TResult>(this TValue value, Func<TValue, TResult> method) where TValue : class
        {
            return value == null ? default(TResult) : method(value);
        }

        public static TResult Try<TValue, TResult>(this TValue? value, Func<TValue, TResult> method) where TValue : struct
        {
            return value.HasValue ? method(value.Value) : default(TResult);
        }

        public static bool IsNull<TValue>(this TValue value) where TValue : class
        {
            return value == null;
        }

        public static bool IsNull<TValue>(this TValue? value) where TValue : struct
        {
            return !value.HasValue;
        }

        public static bool IsPresent<TValue>(this TValue value) where TValue : class
        {
            return value != null;
        }

        public static bool IsPresent<TValue>(this TValue? value) where TValue : struct
        {
            return value.HasValue;
        }

        public static TValue Tap<TValue>(this TValue value, Action<TValue> block)
        {
            block(value);
            return value;
        }
    }
}

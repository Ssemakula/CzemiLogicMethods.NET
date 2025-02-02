using System.Numerics;

namespace Czemi.LogicMethods
{
    /// <summary>
    /// Implements C type logic where 0 or null is false else true
    /// </summary>
    public static class Logic
    {
        public static bool IsTrue(this int value) => value != 0;

        public static bool IsTrue(this uint value) => value != 0;

        public static bool IsTrue(this long value) => value != 0;

        public static bool IsTrue(this ulong value) => value != 0;

        public static bool IsTrue(this short value) => value != 0;

        public static bool IsTrue(this ushort value) => value != 0;

        public static bool IsTrue(this BigInteger value) => value != 0;

        public static bool IsTrue(this byte value) => value != 0;

        public static bool IsTrue(this sbyte value) => value != 0;

        public static bool IsTrue(this float value) => value != 0;

        public static bool IsTrue(this double value) => value != 0;

        public static bool IsTrue(this decimal value) => value != 0;

        public static bool IsTrue(this Enum value) => Convert.ToInt64(value) != 0;

        public static bool IsTrue(this string value) => !string.IsNullOrEmpty(value);

        public static bool IsTrue(this object value) => value != null;
    }
}
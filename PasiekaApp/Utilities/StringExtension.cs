using System.Numerics;

namespace Utilities
{
    public static class StringExtension
    {
        public static bool IsNEoWS(this string @this)
        {
            if (@this == null)
                return true;
            @this = @this.Trim();
            if (@this.Length == 0)
                return true;
            return false;
        }
    }
}

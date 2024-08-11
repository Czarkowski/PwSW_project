using System.Numerics;

namespace Utilities.StaticExtensions
{
    public static class StringExtensions
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

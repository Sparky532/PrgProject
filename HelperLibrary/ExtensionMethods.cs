using System;

namespace HelperLibrary
{
    public static class ExtensionMethods
    {
        public static string MaxCages(this int farmSize)
        {
            return ((Math.Pow((Math.Sqrt(farmSize) * 17.5 / 175), 2)) - 1).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

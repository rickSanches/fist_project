using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace tringle
{
    public static class Only
    {
        const string pattern = @"\b\d+$";
        public static Regex regex = new Regex(pattern);

        public static bool HasNumberOnly(this string input)
        {
            Match match = regex.Match(input);
            return match.Success;
        }
    }
}
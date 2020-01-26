using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamPhones.Core.Helpers
{
    public static class SearchHelper
    {
            public static List<string> SearchForStation(string SearchTerm, List<string> stations)
            {

            stations.Sort();
            
            var result = stations.Where(s => s.ToLower().StartsWith(SearchTerm.ToLower())).ToList();
            return result;
            }

        public static void InputChecks(ref char? inputChar, ref StringBuilder sb)
        {
            if (inputChar == '\b' && sb.Length != 0)
            {
                sb.Remove(sb.Length - 1, 1);

            }
            else if (inputChar != '\b')
                sb.Append(inputChar);
        }
    }
}

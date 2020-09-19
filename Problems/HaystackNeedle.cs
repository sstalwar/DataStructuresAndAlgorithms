using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class HaystackNeedle
    {
        public List<int> SolveHaystackNeedle(string needle, string haystack)
        {
            List<int> result = new List<int>();

            if (needle.Length == 0 || needle.Length > haystack.Length)
            {                
                return result;
            }

            var i = 0;

            while(i <= haystack.Length - needle.Length)
            {
                if(needle[0] == haystack[i])
                {
                    var isPresent = CompareSubstring(needle, haystack, i+1);
                    if(isPresent)
                    {
                        result.Add(i);
                    }
                }
                i++;
            }
            return result;
        }

        private bool CompareSubstring(string needle, string haystack, int i)
        {
            var p = 1;
            while(i < needle.Length)
            {
                if(needle[p] != haystack[i])
                {
                    return false;
                }
                i++;
                p++;
            }
            return true;
        }
    }
}

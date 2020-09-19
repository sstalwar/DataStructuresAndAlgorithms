using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*
            function int[]/List grep(string haystack, string needle)
            haystack = "aaabcdddbbddddabcdefghi"
            needle = "abc"
            [2,14]
            */

            var hayestackneedle = new HaystackNeedle();
            var result = hayestackneedle.SolveHaystackNeedle("bb", "bbbbbbb");
            var output = string.Join(",", result);
            Console.WriteLine("[" + output + "]");

        }
    }
}

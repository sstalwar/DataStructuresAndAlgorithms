using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms ");
            int[] A = { 2, 7, 4, 1, 5, 3 };
            Console.WriteLine("Actual Array: ");
            A.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            Console.WriteLine();

            //Selection Sort
            var selection = new SelectionSort();
            var sortedA = selection.Sort(A);
            Console.WriteLine("\nSelection sorted Array: ");
            sortedA.ToList().ForEach(i => Console.Write(i.ToString() + " "));

            //Bubble Sort
            Console.ReadLine();
        }
    }
}

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
            var selectionSortedA = selection.Sort(A);
            Console.WriteLine("\nSelection sorted Array: ");
            selectionSortedA.ToList().ForEach(i => Console.Write(i.ToString() + " "));

            //Bubble Sort
            var bubble = new BubbleSort();
            var bubbleSortedA = bubble.Sort(A);
            Console.WriteLine("\nBubble sorted Array: ");
            bubbleSortedA.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            Console.ReadLine();
        }
    }
}

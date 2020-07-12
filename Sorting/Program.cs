using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms ");


            //Selection Sort
            int[] A = { 2, 7, 4, 1, 5, 3 };
            Console.WriteLine("Actual Array: ");
            A.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            //Console.WriteLine();
            var selection = new SelectionSort();
            var selectionSortedA = selection.Sort(A);
            Console.WriteLine("\nSelection sorted Array: ");
            selectionSortedA.ToList().ForEach(i => Console.Write(i.ToString() + " "));

            //Bubble Sort
            int[] B = { 2, 7, 4, 1, 5, 3 };
            Console.WriteLine("\n\nActual Array: ");
            B.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            var bubble = new BubbleSort();
            var bubbleSortedB = bubble.Sort(B);
            Console.WriteLine("\nBubble sorted Array: ");
            bubbleSortedB.ToList().ForEach(i => Console.Write(i.ToString() + " "));

            //Insertion Sort
            int[] C = { 2, 7, 4, 1, 5, 3 };
            Console.WriteLine("\n\nActual Array: ");
            C.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            var insertion = new InsertionSort();            
            var insertionSortedC = insertion.Sort(C);
            Console.WriteLine("\nInsertion sorted Array: ");
            insertionSortedC.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            Console.ReadLine();
        }
    }
}

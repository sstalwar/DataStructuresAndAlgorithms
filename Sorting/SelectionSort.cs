using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class SelectionSort
    {
        public int[] Sort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                        min = j;
                }
                int temp = A[i];
                A[i] = A[min];
                A[min] = temp;
            }
            return A;
        }
    }
}

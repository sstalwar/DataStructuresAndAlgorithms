using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class BubbleSort
    {
        public int[] Sort(int[] A)
        {
            for (int k = A.Length - 1; k > 0; k--)
            {
                for (int i = 0; i < k; i++)
                {
                    if (A[i + 1] < A[i])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
            return A;
        }
    }
}

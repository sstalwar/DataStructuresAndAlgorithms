using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class InsertionSort
    {
        public int[] Sort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int temp = A[i];
                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (A[j] > temp)
                    {
                        A[j+1] = A[j];
                    }
                    else
                    {
                        break;
                    }
                }
                A[j+1] = temp;
            }
            return A;
        }
    }
}

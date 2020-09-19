using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixOperations
{
    class MatrixOperations
    {
        public void RotateMatrix(int[,] a, int m, int n)
        {
            int top = 0, bottom = m-1, left = 0, right = n-1, dir = 0;
            
            while(top <= bottom && left <= right)
            { 
                if(dir == 0)
                {
                    for(int i=left; i<= right; i++)
                    {
                        Console.WriteLine(a[top, i]);                        
                    }
                    top++;
                    dir = 1;
                }
                else if(dir == 1)
                {
                    for(int i=top; i<=bottom; i++)
                    {
                        Console.WriteLine(a[i, right]);
                    }
                    right--;
                    dir = 2;
                }
                else if(dir == 2)
                {
                    for(int i=right; i>=left; i--)
                    {
                        Console.WriteLine(a[bottom, i]);                        
                    }
                    bottom--;
                    dir = 3;
                } else if(dir == 3)
                {
                    for(int i=bottom; i>= top; i--)
                    {
                        Console.WriteLine(a[i, left]);
                    }
                    left++;
                    dir = 0;
                }
            }


        }
    }
}

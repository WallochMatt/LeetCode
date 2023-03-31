using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Fib
    {
        public int fib(int n) 
        {
            int x = 0;
            int y = 1; 
            int z = 1;


            for (int i = 0; i < n; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            return z;
        }
    }
}

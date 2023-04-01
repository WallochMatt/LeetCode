using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    internal class IsPrime
    {
        public bool checksPrime(int givenNumber)
        {
            if (givenNumber <= 1) 
            { 
                return false;
            }

            int currentNumber = 2;
            while (currentNumber <= (givenNumber / 2)) 
            { 
                if (givenNumber % currentNumber == 0) 
                { 
                    return false;
                }
                currentNumber++;
            }
            return true;
            
        }

    }
}

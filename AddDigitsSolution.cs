using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddDigitsSolution
    {
        public static int AddDigits(int num)
        {
            string numAsString = num.ToString();
            double addedDigits = 0;

            for (int i = 0; i < numAsString.Length; i++)
            {
                addedDigits += Char.GetNumericValue(numAsString[i]);
            }

            if (addedDigits > 9)
            {
                addedDigits = AddDigits(Convert.ToInt32(addedDigits));
            }  

            return Convert.ToInt32(addedDigits);
        }

    }
}

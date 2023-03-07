using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        try
                        {
                            if (s[i + 1] == 'V' || s[i + 1] == 'X')
                            {
                                total -= 1;
                            }
                            else
                            {
                                total += 1;
                            }
                            break;
                        }
                        catch
                        {
                            total += 1;
                            break;
                        }

 
                    case 'V':
                        total += 5;
                        break;

                    case 'X':
                        try
                        {
                            if (s[i + 1] == 'L' || s[i + 1] == 'C')
                            {
                                total -= 10;
                            }
                            else
                            {
                                total += 10;
                            }
                            break;
                        }
                        catch
                        {
                            total += 10;
                            break;
                        }


                    case 'L':
                        total += 50;
                        break;

                    case 'C':
                        try
                        {
                            if (s[i + 1] == 'D' || s[i + 1] == 'M')
                            {
                                total -= 100;
                            }
                            else
                            {
                                total += 100;
                            }
                            break;
                        }
                        catch
                        {
                            total += 100;
                            break;
                        }

                    case 'D':
                        total += 500;
                        break;

                    case 'M':
                        total += 1000;
                        break;

                }
            }
            return total;   
        }
    }
}

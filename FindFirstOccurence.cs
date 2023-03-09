using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindFirstOccurence
    {
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);   
        }

    }
}

//FindFirstOccurence test = new FindFirstOccurence();
//int result = test.StrStr("sadbutsad", "but");

//Console.WriteLine(result);
//Console.ReadLine();
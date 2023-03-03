using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            bool copyFound = false;
            int copy = 0;   
            foreach (int num in nums)
            {
                if (Array.Exists(nums, element => element.Equals(target - num) == true) && target / 2 != num)
                {
                    Console.WriteLine("Test Passed");
                    int index1 = Array.IndexOf(nums, num);
                    int index2 = Array.IndexOf(nums, target - num);
                    int[] retArray= new int[] {index1, index2};
                    Console.WriteLine(retArray);
                    return retArray;
                }
                else if (target / 2 == num)
                {
                    copyFound = true;
                    copy = num;
                }
                else { Console.WriteLine("fail");  }
            };

            if (copyFound == true)
            {
                int index1 = Array.IndexOf(nums, copy);
                int index2 = Array.IndexOf(nums, copy, index1 + 1);
                int[] retArray = new int[] { index1, index2 };
                return retArray;
            }

            Console.WriteLine("super fail");
            return nums;
        }
    }
};

//Program file

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array1 = new int[] { 3, 3 };
//            int target = 6;
//            //Console.WriteLine( Array.IndexOf(array1, 3));
//            //Console.ReadLine();

//            Solution.TwoSum(array1, target);
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> bracketsMap = new Dictionary<char, char>
            {
                {'{',  '}'},
                {'(',  ')'},
                {'[',  ']'},
            };
            Stack<char> stackOfBrackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracketsMap.ContainsKey(bracket))
                {
                    stackOfBrackets.Push(bracket);
                }
                else
                {
                    if (stackOfBrackets.Count == 0)
                    {
                        return false;
                    }
                    if (bracketsMap[stackOfBrackets.Pop()] == bracket)
                    {
                        continue;
                    };
                    return false;
                }
            }
            return stackOfBrackets.Count == 0;
        }
    }
}

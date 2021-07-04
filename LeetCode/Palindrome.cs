using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Palindrome
    {
        public bool IsPalindrome(int number)
        {
            bool isPalindrome = true;
            string numberString = number.ToString();
            for(int i = 0; i < numberString.Length; ++i)
            {
                if(numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}

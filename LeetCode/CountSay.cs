using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountSay
    {
        public string CountAndSay(int n)
        {
            int i = 1;
            string s = string.Empty;
            while(i <= n)
            {
                s += RecursiveCountAndSay(i);
            }
            return "";
        }
        public string RecursiveCountAndSay(int n)
        {

        }
    }
}

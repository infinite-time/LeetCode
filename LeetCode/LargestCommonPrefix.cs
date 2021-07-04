using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LargestCommonPrefix
    {
        public string FindLargestCommonPrefix(string [] inputs)
        {
            string prefix = inputs[0];
            for(int i = 1; i < inputs.Length; ++i)
            {
                while(inputs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if(string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}

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
            if(n > 1)
            {
                string s = CountAndSay(n - 1);
                string formation = string.Empty;
                List<int> nums = new List<int>();
                int prev = 0;
                for(int i = 0; i < s.Length; ++i)
                {
                    int curr = (int)char.GetNumericValue(s[i]);
                    if (prev == curr)
                    {
                        int count = nums[nums.Count - 2];
                        nums.RemoveAt(nums.Count - 1);
                        nums.RemoveAt(nums.Count - 1);
                        nums.Add(count+1);
                        nums.Add(curr);
                    }
                    else
                    {
                        nums.Add(1);
                        nums.Add(curr);
                    }
                    prev = curr;
                }
                for(int i = 0; i < nums.Count; ++i)
                {
                    formation += Convert.ToString(nums[i]);
                }
                return formation;
            }
            else
            {
                return "1";
            }
        }
    }
}

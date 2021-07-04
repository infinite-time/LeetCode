using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int area = 0, left = 0, right = height.Length - 1;
            for(int i = 0; i < height.Length; ++i)
            {
                while (left < right)
                {
                    area = Math.Max(area, Math.Min(height[left], height[right]) * (right - left));
                    if(height[left] < height[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return area;
        }
    }
}

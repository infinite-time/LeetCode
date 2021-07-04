using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToInt
    {
        const char I = 'I';
        const char V = 'V';
        const char X = 'X';
        const char L = 'L';
        const char C = 'C';
        const char D = 'D';
        const char M = 'M';
        Dictionary<char, int> romanToIntMap = new Dictionary<char, int>()
        {
            { I, 1 },
            { V, 5 },
            { X, 10 },
            { L, 50 },
            { C, 100 },
            { D, 500 },
            { M, 1000 }
        };
        public int Convert(string roman)
        {
            int prevCharValue = 0;
            int integerEquivalent = 0;
            for(int i = 0; i < roman.Length; ++i)
            {
                char c = roman[i];
                int currentCharValue = romanToIntMap[c];
                if(i != 0)
                {
                    if (currentCharValue <= prevCharValue)
                    {
                        integerEquivalent += currentCharValue;
                    }
                    else
                    {
                        int intermediate = currentCharValue - prevCharValue;
                        if(intermediate < integerEquivalent)
                        {
                            integerEquivalent += (currentCharValue - prevCharValue) - prevCharValue;
                        }
                        else
                        {
                            integerEquivalent = intermediate;
                        }
                    }
                }
                else
                {
                    integerEquivalent = currentCharValue;
                }
               
                prevCharValue = currentCharValue;
            }
            return integerEquivalent;
        }
    }
}

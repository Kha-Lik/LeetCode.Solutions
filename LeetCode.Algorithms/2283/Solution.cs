using System.Collections.Generic;

namespace LeetCode.Algorithms._2283;

public class Solution
{
    public bool DigitCount(string num)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in num)
        {
            if (!dict.ContainsKey(c)) dict[c] = 1;
            else dict[c]++;
        }
        
        for (var i = 0; i < num.Length; i++)
        {
            var digit = (char) (i + '0');
            var count = num[i] - '0';
            if (!(dict.ContainsKey(digit)))
                if (count == 0) continue;
                else return false;
            if(dict[digit] != count)
                return false;
        }

        return true;
    }
}
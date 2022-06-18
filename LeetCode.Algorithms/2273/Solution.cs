using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms._2273;

public class Solution {
    public IList<string> RemoveAnagrams(string[] words)
    {
        var stack = new Stack<string>();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            string s = words[i];
            while (stack.Count != 0 && AreAnagrams(stack.Peek(), s)) 
                stack.Pop();
            stack.Push(s);
        }

        var res = new List<string>();
        while (stack.Count != 0) 
            res.Add(stack.Pop());
        return res;
    }

    private static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        var dict = new Dictionary<char, int>();
        
        foreach (var c in str1)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }
        
        foreach (var c in str2)
        {
            if (dict.ContainsKey(c))
                dict[c]--;
        }
        
        foreach (var dictKey in dict.Keys)
        {
            if (dict[dictKey] != 0) return false;
        }

        return true;
    }
}
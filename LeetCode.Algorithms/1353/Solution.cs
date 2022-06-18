using System.Linq;

namespace LeetCode.Algorithms._1353;

public class Solution {
    public int MaxEvents(int[][] events)
    {
        var min = events.Select(x => x[0]).Min();
        var counter = 1;
        var current = events.First(e => e[0] == 1);
        while (true)
        {
            current = events.FirstOrDefault(e => e[0] == current[1]);
            if (current is not null)
                counter++;
            else
                break;
            
        }

        return counter;
    }
}
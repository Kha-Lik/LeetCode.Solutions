using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms._841;

public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new HashSet<int>();
        var next = new Stack<IList<int>>();

        visited.Add(0);
        next.Push(rooms[0]);
        
        while (next.Count is not 0)
        {
            var keys = next.Pop();
            for (var i = 0; i < keys.Count; i++)
            {
                var key = keys[i];
                if(visited.Contains(key)) continue;
                next.Push(rooms[key]);
                visited.Add(key);
            }
        }

        return visited.Count == rooms.Count;
    }
}
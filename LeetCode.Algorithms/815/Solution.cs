using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms._815;

public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var graph = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < routes.GetLength(0); i++)
        {
            var stops = routes[i];
            for (var j = 0; j < stops.Length; j++)
            {
                var stop = stops[j];
                if (!graph.ContainsKey(stop)) 
                    graph[stop] = new HashSet<int>();
                graph[stop].UnionWith(stops.Where(s => s != stop));
            }
        }
        return -1;
    }
}
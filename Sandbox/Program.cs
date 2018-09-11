using System;
using System.Collections.Generic;
using Sandbox.Graphs;

namespace Sandbox
{
    class Program
    {
        public static void Main(string[] args)
        {
            DepthFirstSearch dfs = new DepthFirstSearch();
            dfs.Run();

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            bfs.Run();
        }
    }
}
using System;
using System.Collections.Generic;
using Sandbox.Graphs;
using Sandbox.DesignPatterns.Strategy;

namespace Sandbox
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DepthFirstSearch dfs = new DepthFirstSearch();
            // dfs.Run();

            // BreadthFirstSearch bfs = new BreadthFirstSearch();
            // bfs.Run();

            // Strategy Pattern
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            // Set Fly Behavior at runtime
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
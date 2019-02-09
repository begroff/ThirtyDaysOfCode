using System;
using System.Collections.Generic;
using Sandbox.Graphs;
using Sandbox.DesignPatterns.Strategy;
using Sandbox.DesignPatterns.Observer;

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

            // // Strategy Pattern
            // Duck mallard = new MallardDuck();
            // mallard.PerformQuack();
            // mallard.PerformFly();

            // // Set Fly Behavior at runtime
            // Duck model = new ModelDuck();
            // model.PerformFly();
            // model.SetFlyBehavior(new FlyRocketPowered());
            // model.PerformFly();

            // Observer Pattern
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4F);
            weatherData.SetMeasurements(82, 70, 29.2F);
            weatherData.SetMeasurements(72, 80, 29.2F);

            Console.ReadKey();

        }
    }
}
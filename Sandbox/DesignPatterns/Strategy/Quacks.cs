using System;

namespace Sandbox.DesignPatterns.Strategy
{
    public class Quacks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
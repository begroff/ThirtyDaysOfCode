using System;

namespace Sandbox.DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(WeatherData data);
    }
}
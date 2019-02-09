using System;
using System.Collections.Generic;

namespace Sandbox.DesignPatterns.Observer.Microsoft
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Observer.WeatherData>> observers;
        private IObserver<Observer.WeatherData> observer;

        public Unsubscriber(List<IObserver<Observer.WeatherData>> observers, IObserver<Observer.WeatherData> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers != null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}
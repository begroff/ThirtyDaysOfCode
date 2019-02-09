using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.DesignPatterns.Observer.Microsoft
{
    public class WeatherStation : IObservable<WeatherData>
    {
        private List<IObserver<Observer.WeatherData>> observers;

        public WeatherStation(Observer.WeatherData weatherData)
        {
            this.observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }
    }
}

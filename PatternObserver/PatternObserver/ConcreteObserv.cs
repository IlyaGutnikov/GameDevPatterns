using System.Collections.Generic;
using PatternObserver.Interfaces;

namespace PatternObserver
{
    /// <summary>
    /// Конкретный наблюдаемый объект
    /// </summary>
    public class ConcreteObserv : IObservable
    {
        private List<IObserver> observers;
        
        public ConcreteObserv()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
 
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
 
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                
                observer.Update(this);
        }
    }
}
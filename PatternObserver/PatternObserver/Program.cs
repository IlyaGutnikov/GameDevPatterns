using System;
using System.Collections.Generic;

namespace PatternObserver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConcreteObserv concreteObserv = new ConcreteObserv();
            ConcreteObserver concreteObserver = new ConcreteObserver();
            
            concreteObserv.AddObserver(concreteObserver);
            concreteObserv.NotifyObservers();
        }
    }
}
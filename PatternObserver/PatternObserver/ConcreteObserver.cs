using System;
using PatternObserver.Interfaces;

namespace PatternObserver
{
    public class ConcreteObserver : IObserver 

    {
        public void Update(Object ob)
        {
            var name = ob.GetType().Name;
            
            Console.WriteLine("Update был вызван из " + name);
        }
    }
}
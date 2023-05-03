using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.Base
{
    internal class Subject : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        public Subject() { }
        public void Notify(int i)
        {
            foreach (var o in _observers)
            {
                o.Update(i);
            }
        }

        public void Register(IObserver o)
        {
            _observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}

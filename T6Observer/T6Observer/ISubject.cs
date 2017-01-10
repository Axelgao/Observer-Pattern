using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
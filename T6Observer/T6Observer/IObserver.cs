using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6Observer
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, int pressure);
    }
}
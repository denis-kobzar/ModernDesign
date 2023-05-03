using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.Base
{
    internal interface IObserver
    {
        public void Update(int i);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.Base
{
    internal class OberverType1 : IObserver
    {
        string nameOfObserver;

        public OberverType1(string name)
        {
            this.nameOfObserver = name;
        }

        public void Update(int i)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.Base
{
    internal class OberverType2 : IObserver
    {
        string nameOfObserver;

        public OberverType2(string name)
        {
            this.nameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} observer: {i}");
        }
    }
}

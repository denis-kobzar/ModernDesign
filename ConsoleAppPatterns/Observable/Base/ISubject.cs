﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.Base
{
    internal interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void Notify(int i);
    }
}

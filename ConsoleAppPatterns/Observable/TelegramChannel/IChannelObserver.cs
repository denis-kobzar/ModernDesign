using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.TelegramChannel
{
    internal interface IChannelObserver
    {
        public void GetPost(string content);
    }
}

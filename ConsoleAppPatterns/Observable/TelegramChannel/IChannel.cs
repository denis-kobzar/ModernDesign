using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.TelegramChannel
{
    internal interface IChannel
    {
        void Subscribe(IChannelObserver channelObserver);
        void Unsubscribe(IChannelObserver channelObserver);
        void Publish(string content);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.TelegramChannel
{
    internal class TelegramChannel : IChannel
    {
        List<IChannelObserver> _observers = new List<IChannelObserver>();
        public void Publish(string content)
        {
            foreach (var observer in _observers)
            {
                observer.GetPost(content);
            }
        }

        public void Subscribe(IChannelObserver channelObserver)
        {
            _observers.Add(channelObserver);
        }

        public void Unsubscribe(IChannelObserver channelObserver)
        {
            _observers.Remove(channelObserver);
        }
    }
}

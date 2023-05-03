using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.TelegramChannel
{
    internal class TelegramUser : IChannelObserver
    {
        public string Name { get; set; }
        public TelegramUser(string name)
        {
            Name = name;
        }

        public void GetPost(string content)
        {
            Console.WriteLine($"GET POST [{Name}]: {content}");
        }
    }
}

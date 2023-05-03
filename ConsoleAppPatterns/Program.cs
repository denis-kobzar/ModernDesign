using ConsoleAppPatterns.Observable.Base;
using ConsoleAppPatterns.Observable.TelegramChannel;
using ConsoleAppPatterns.Observable.TelegramChannel.Service;

namespace ConsoleAppPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = TelegramUserService.CreateUsers(new List<string>
            {
                "Kavun",
                "Moon",
                "KhersonLight"
            });

            var channel = new TelegramChannel();
            TelegramUserService.Subscribe(channel, users);

            channel.Publish("Post 1");
            channel.Publish("Post 2");
        }
    }
}
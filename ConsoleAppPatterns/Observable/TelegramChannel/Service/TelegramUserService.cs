using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPatterns.Observable.TelegramChannel.Service
{
    internal class TelegramUserService
    {
        public static TelegramUser CreateUser(string name)
        {
            return new TelegramUser(name);
        }

        public static List<TelegramUser> CreateUsers(List<string> names)
        {
            List<TelegramUser> users = new List<TelegramUser>();
            foreach (string name in names)
            {
                users.Add(CreateUser(name));
            }
            return users;
        }

        public static void Subscribe(TelegramChannel telegramChannel, TelegramUser user) 
        {
            if (telegramChannel != null && user != null)
            {
                telegramChannel.Subscribe(user);
            }
        }

        public static void Subscribe(TelegramChannel telegramChannel, List<TelegramUser> users)
        {
            if (telegramChannel != null && users != null)
            {
                foreach (TelegramUser user in users)
                {
                    Subscribe(telegramChannel, user);
                }
            }
        }
    }
}

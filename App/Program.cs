using Bot;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bot = new BotService();

            await bot.SendTextMessageAsync("Vafs");

            //while (true)
            //{
            //    var updates = await bot.GetUpdatesAsync();
            //    if (updates.Any())
            //    {
            //        //TODO: Do Something
            //    }
            //}
        }
    }
}

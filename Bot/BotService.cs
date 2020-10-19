using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bot
{
    public interface IBotService
    {
        Task<Update[]> GetUpdatesAsync(int lastUpdateId = 0);
        Task<Message> SendTextMessageAsync(string message);
    }
    public class BotService : IBotService
    {
        private readonly TelegramBotClient _client;
        private readonly ChatId _channelChatId;

        public BotService()
        {
            _channelChatId = "-1001231208844";
            _client = new TelegramBotClient("1111955339:AAHrD_74nRFTCjL20xZ8UbJ_F2Mz86rjkb0");
        }

        public async Task<Message> SendTextMessageAsync(string message)
        {
            if (message is null)
                throw new ArgumentNullException(nameof(message));

            return await _client.SendTextMessageAsync(_channelChatId, message);
        }

        public async Task<Update[]> GetUpdatesAsync(int lastUpdateId = 0)
        {
            return await _client.GetUpdatesAsync(lastUpdateId);
        }
    }


}

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using UABot.ReactionLogic;
using UABot.Services;

namespace UABot
{
    class Program
    {
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            using (var services = ConfigureServices())
            {
                var client = services.GetRequiredService<DiscordSocketClient>();

                client.Log += LogAsync;
                services.GetRequiredService<CommandService>().Log += LogAsync;

                await client.LoginAsync(TokenType.Bot, "NjU0Njc1NTY2NTY1NTIzNDU3.XfNmZw.dIuTNIEFHZ7mIgkpKNzuPeY3pL4");
                await client.StartAsync();

                await services.GetRequiredService<CommandHandlingService>().InitializeAsync();

                await Task.Delay(-1);
            }
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());

            return Task.CompletedTask;
        }

        private ServiceProvider ConfigureServices()
        {
            var config = new DiscordSocketConfig { MessageCacheSize = 50 };
            var client = new DiscordSocketClient(config);

            return new ServiceCollection()
                .AddSingleton(client)
                .AddSingleton<CommandService>()
                .AddSingleton<CommandHandlingService>()
                .AddSingleton<HttpClient>()
                .AddSingleton<CalenderService>()
                .AddSingleton<PictureService>()
                .AddSingleton<GeneralReactionLogic>()
                .BuildServiceProvider();
        }
    }
}
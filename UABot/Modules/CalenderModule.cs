using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Database;
using Discord;
using Discord.Commands;
using Models.Calendar;
using UABot.Emoticons;
using UABot.Services;

namespace UABot.Modules
{
    public partial class CalenderModule : ModuleBase<SocketCommandContext>
    {
        public CalenderService CalenderService { get; set; }

        [Command("newraid")]
        //[RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task CreateNewRaid(string raid, string difficulty, string dateTime, IUser user = null)
        {
            user??= Context.User;

            var parsedDate = DateTime.Parse(dateTime);

            var dTo = new CreateCalendarDto()
            {
                RaidNaam = raid,
                Difficulty = difficulty,
                User = user,
            };

            CalenderService.CreateCalendarRaidEvent(dTo);

            await ReplyAsync("Event Created");
        }

        [Command("nextraid")]
        public async Task ShowNextRaid()
        {
            var message = await ReplyAsync(FakeEvents.Event1().ToString());
        }

        [Command("accept")]
        public async Task ReturnAcceptEmoticon()
        {
            await ReplyAsync(EmojiList.Accepted.Name);
        }

        [Command("decline")]
        public async Task ReturnDeclineEmoticon()
        {
            await ReplyAsync(EmojiList.Declined.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace UABot.Helpers
{
    public class ReactionNet
    {
        public Optional<IUser> UserToReact { get; set; }
       public IEmote Emote { get; set; }
       public ulong ChannelId { get; set; }
       public DateTimeOffset TimeReacted { get; set; }
       public ulong MessageId { get; set; }
            
    }
}

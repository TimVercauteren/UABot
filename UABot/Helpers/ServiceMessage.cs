using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace UABot.Helpers
{
    public class ServiceMessage : IServiceMessage
    {
        public string MessageToReply { get; set; }
        public Status Status { get; set; }
        public IUser DmUser { get; set; }
    }
}

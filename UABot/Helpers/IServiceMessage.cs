using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace UABot.Helpers
{
    public interface IServiceMessage
    {
        string MessageToReply { get; set; }
        Status Status { get; set; }
        IUser DmUser { get; set; }
    }

    public enum Status
    {
        NoResult,
        ResultOk
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UABot.Helpers
{
    public interface IServiceMessage
    {
        string MessageToReply { get; set; }
        Status Status { get; set; }
    }

    public enum Status
    {
        NoResult,
        ResultOk
    }
}

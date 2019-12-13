using System;
using System.Collections.Generic;
using System.Text;

namespace UABot.Helpers
{
    public sealed class NullServiceMessage : IServiceMessage
    {
        static NullServiceMessage()
        {

        }

        public static NullServiceMessage Instance { get; } = new NullServiceMessage();

        public string MessageToReply {
            get => "";
            set {
            }
        }

        public Status Status {
            get => Status.NoResult;
            set {

            }
        }
    }
}

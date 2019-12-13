using System.Threading.Tasks;
using UABot.Emoticons;
using UABot.Helpers;

namespace UABot.ReactionLogic
{
    public class GeneralReactionLogic
    {
        public async Task<IServiceMessage> VerwerkReaction(ReactionNet reaction)
        {
            var message = string.Empty;

            if (reaction.ChannelId == StaticChannels.TestChannel)
            {
                message = "Emoticon not known";
                if (Equals(reaction.Emote, EmojiList.Accepted))
                {
                    message = $"Accepted invite";
                }
                if (Equals(reaction.Emote, EmojiList.Declined))
                {
                    message = $"Declined invite";
                }

                return new ServiceMessage{ Status = Status.ResultOk, MessageToReply = message};
            }

            return NullServiceMessage.Instance;
        }
    }


}

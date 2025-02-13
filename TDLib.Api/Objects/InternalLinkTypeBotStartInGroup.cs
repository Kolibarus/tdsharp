using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a Telegram bot, which is supposed to be added to a group chat. Call searchPublicChat with the given bot username, check that the user is a bot and can be added to groups,
            /// </summary>
            public class InternalLinkTypeBotStartInGroup : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeBotStartInGroup";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Username of the bot
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_username")]
                public string BotUsername { get; set; }

                /// <summary>
                /// The parameter to be passed to sendBotStartMessage
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("start_parameter")]
                public string StartParameter { get; set; }
            }
        }
    }
}
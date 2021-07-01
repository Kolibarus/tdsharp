using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Adds a new member to a chat. Members can't be added to private or secret chats
        /// </summary>
        public class AddChatMember : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addChatMember";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// The number of earlier messages from the chat to be forwarded to the new member; up to 100. Ignored for supergroups and channels
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("forward_limit")]
            public int ForwardLimit { get; set; }
        }

        /// <summary>
        /// Adds a new member to a chat. Members can't be added to private or secret chats
        /// </summary>
        public static Task<Ok> AddChatMemberAsync(
            this Client client, long chatId = default, int userId = default, int forwardLimit = default)
        {
            return client.ExecuteAsync(new AddChatMember
            {
                ChatId = chatId, UserId = userId, ForwardLimit = forwardLimit
            });
        }
    }
}
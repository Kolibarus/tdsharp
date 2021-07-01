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
        /// Returns information about a single member of a chat
        /// </summary>
        public class GetChatMember : Function<ChatMember>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatMember";

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
            /// Member identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_id")]
            public MessageSender MemberId { get; set; }
        }

        /// <summary>
        /// Returns information about a single member of a chat
        /// </summary>
        public static Task<ChatMember> GetChatMemberAsync(
            this Client client, long chatId = default, MessageSender memberId = default)
        {
            return client.ExecuteAsync(new GetChatMember
            {
                ChatId = chatId, MemberId = memberId
            });
        }
    }
}
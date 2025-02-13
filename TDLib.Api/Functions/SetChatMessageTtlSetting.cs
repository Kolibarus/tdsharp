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
        /// Changes the message TTL setting (sets a new self-destruct timer) in a chat. Requires can_delete_messages administrator right in basic groups, supergroups and channels
        /// </summary>
        public class SetChatMessageTtlSetting : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatMessageTtlSetting";

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
            /// New TTL value, in seconds; must be one of 0, 86400, 604800 unless chat is secret
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ttl")]
            public int Ttl { get; set; }
        }

        /// <summary>
        /// Changes the message TTL setting (sets a new self-destruct timer) in a chat. Requires can_delete_messages administrator right in basic groups, supergroups and channels
        /// </summary>
        public static Task<Ok> SetChatMessageTtlSettingAsync(
            this Client client, long chatId = default, int ttl = default)
        {
            return client.ExecuteAsync(new SetChatMessageTtlSetting
            {
                ChatId = chatId, Ttl = ttl
            });
        }
    }
}
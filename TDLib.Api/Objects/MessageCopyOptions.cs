using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Options to be used when a message content is copied without a link to the original message. Service messages and messageInvoice can't be copied
        /// </summary>
        public partial class MessageCopyOptions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageCopyOptions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if content of the message needs to be copied without a link to the original message. Always true if the message is forwarded to a secret chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_copy")]
            public bool SendCopy { get; set; }

            /// <summary>
            /// True, if media caption of the message copy needs to be replaced. Ignored if send_copy is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("replace_caption")]
            public bool ReplaceCaption { get; set; }

            /// <summary>
            /// New message caption. Ignored if replace_caption is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_caption")]
            public FormattedText NewCaption { get; set; }
        }
    }
}
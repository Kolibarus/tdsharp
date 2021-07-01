using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputChatPhoto : Object
        {
            /// <summary>
            /// Describes a photo to be set as a user profile or chat photo
            /// </summary>
            public class InputChatPhotoPrevious : InputChatPhoto
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputChatPhotoPrevious";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the current user's profile photo to reuse
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("chat_photo_id")]
                public long ChatPhotoId { get; set; }
            }
        }
    }
}
using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// A voice chat participant was muted or unmuted
            /// </summary>
            public class ChatEventVoiceChatParticipantIsMutedToggled : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventVoiceChatParticipantIsMutedToggled";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the affected group call participant
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("participant_id")]
                public MessageSender ParticipantId { get; set; }

                /// <summary>
                /// New value of is_muted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_muted")]
                public bool IsMuted { get; set; }
            }
        }
    }
}
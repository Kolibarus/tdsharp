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
        /// Describes a voice chat
        /// </summary>
        public partial class VoiceChat : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "voiceChat";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier of an active voice chat; 0 if none. Full informationa about the voice chat can be received through the method getGroupCall
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// True, if the voice chat has participants
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_participants")]
            public bool HasParticipants { get; set; }

            /// <summary>
            /// Default group call participant identifier to join the voice chat; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("default_participant_id")]
            public MessageSender DefaultParticipantId { get; set; }
        }
    }
}
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
        /// Represents a set of filters used to obtain a chat event log
        /// </summary>
        public partial class ChatEventLogFilters : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatEventLogFilters";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if message edits should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_edits")]
            public bool MessageEdits { get; set; }

            /// <summary>
            /// True, if message deletions should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_deletions")]
            public bool MessageDeletions { get; set; }

            /// <summary>
            /// True, if pin/unpin events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_pins")]
            public bool MessagePins { get; set; }

            /// <summary>
            /// True, if members joining events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_joins")]
            public bool MemberJoins { get; set; }

            /// <summary>
            /// True, if members leaving events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_leaves")]
            public bool MemberLeaves { get; set; }

            /// <summary>
            /// True, if invited member events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_invites")]
            public bool MemberInvites { get; set; }

            /// <summary>
            /// True, if member promotion/demotion events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_promotions")]
            public bool MemberPromotions { get; set; }

            /// <summary>
            /// True, if member restricted/unrestricted/banned/unbanned events should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_restrictions")]
            public bool MemberRestrictions { get; set; }

            /// <summary>
            /// True, if changes in chat information should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("info_changes")]
            public bool InfoChanges { get; set; }

            /// <summary>
            /// True, if changes in chat settings should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("setting_changes")]
            public bool SettingChanges { get; set; }

            /// <summary>
            /// True, if changes to invite links should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link_changes")]
            public bool InviteLinkChanges { get; set; }

            /// <summary>
            /// True, if voice chat actions should be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("voice_chat_changes")]
            public bool VoiceChatChanges { get; set; }
        }
    }
}
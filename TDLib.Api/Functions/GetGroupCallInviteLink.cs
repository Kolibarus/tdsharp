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
        /// Returns invite link to a voice chat in a public chat
        /// </summary>
        public class GetGroupCallInviteLink : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getGroupCallInviteLink";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// Pass true if the invite_link should contain an invite hash, passing which to joinGroupCall would allow the invited user to unmute themselves. Requires groupCall.can_be_managed group call flag
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_self_unmute")]
            public bool CanSelfUnmute { get; set; }
        }

        /// <summary>
        /// Returns invite link to a voice chat in a public chat
        /// </summary>
        public static Task<HttpUrl> GetGroupCallInviteLinkAsync(
            this Client client, int groupCallId = default, bool canSelfUnmute = default)
        {
            return client.ExecuteAsync(new GetGroupCallInviteLink
            {
                GroupCallId = groupCallId, CanSelfUnmute = canSelfUnmute
            });
        }
    }
}
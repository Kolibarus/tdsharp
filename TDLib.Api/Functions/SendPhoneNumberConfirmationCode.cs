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
        /// Sends phone number confirmation code to handle links of the type internalLinkTypePhoneNumberConfirmation
        /// </summary>
        public class SendPhoneNumberConfirmationCode : Function<AuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendPhoneNumberConfirmationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Hash value from the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("hash")]
            public string Hash { get; set; }

            /// <summary>
            /// Phone number value from the link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Settings for the authentication of the user's phone number
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("settings")]
            public PhoneNumberAuthenticationSettings Settings { get; set; }
        }

        /// <summary>
        /// Sends phone number confirmation code to handle links of the type internalLinkTypePhoneNumberConfirmation
        /// </summary>
        public static Task<AuthenticationCodeInfo> SendPhoneNumberConfirmationCodeAsync(
            this Client client, string hash = default, string phoneNumber = default,
            PhoneNumberAuthenticationSettings settings = default)
        {
            return client.ExecuteAsync(new SendPhoneNumberConfirmationCode
            {
                Hash = hash, PhoneNumber = phoneNumber, Settings = settings
            });
        }
    }
}
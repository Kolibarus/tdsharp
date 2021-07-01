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
        /// Returns information about the type of an internal link. Returns a 404 error if the link is not internal. Can be called before authorization
        /// </summary>
        public class GetInternalLinkType : Function<InternalLinkType>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getInternalLinkType";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("link")]
            public string Link { get; set; }
        }

        /// <summary>
        /// Returns information about the type of an internal link. Returns a 404 error if the link is not internal. Can be called before authorization
        /// </summary>
        public static Task<InternalLinkType> GetInternalLinkTypeAsync(
            this Client client, string link = default)
        {
            return client.ExecuteAsync(new GetInternalLinkType
            {
                Link = link
            });
        }
    }
}
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
        /// Downloads a file from the cloud. Download progress and completion of the download will be notified through updateFile updates
        /// </summary>
        public class DownloadFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "downloadFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the file to download
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }

            /// <summary>
            /// Priority of the download (1-32). The higher the priority, the earlier the file will be downloaded. If the priorities of two files are equal, then the last one for which downloadFile was called will be downloaded first
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("priority")]
            public int Priority { get; set; }

            /// <summary>
            /// The starting position from which the file should be downloaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public int Offset { get; set; }

            /// <summary>
            /// Number of bytes which should be downloaded starting from the "offset" position before the download will be automatically canceled; use 0 to download without a limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }

            /// <summary>
            /// If false, this request returns file state just after the download has been started. If true, this request returns file state only after
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("synchronous")]
            public bool Synchronous { get; set; }
        }

        /// <summary>
        /// Downloads a file from the cloud. Download progress and completion of the download will be notified through updateFile updates
        /// </summary>
        public static Task<File> DownloadFileAsync(
            this Client client, int fileId = default, int priority = default, int offset = default, int limit = default,
            bool synchronous = default)
        {
            return client.ExecuteAsync(new DownloadFile
            {
                FileId = fileId, Priority = priority, Offset = offset, Limit = limit, Synchronous = synchronous
            });
        }
    }
}
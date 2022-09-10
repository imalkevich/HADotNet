using Newtonsoft.Json;

namespace HADotNet.Core.Models
{
    /// <summary>
    /// The repository object.
    /// </summary>
    public class RepositoryObject
    {
        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}

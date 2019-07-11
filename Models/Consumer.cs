// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Consumer
    {
        /// <summary>
        /// Initializes a new instance of the Consumer class.
        /// </summary>
        public Consumer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Consumer class.
        /// </summary>
        /// <param name="username">The unique username of the consumer. You
        /// must send either this field or custom_id with the request.</param>
        /// <param name="customId">Field for storing an existing unique ID for
        /// the consumer - useful for mapping Kong with users in your existing
        /// database. You must send either this field or username with the
        /// request.</param>
        /// <param name="id">Uid.</param>
        /// <param name="createdAt">Unix timestamp of the create action</param>
        public Consumer(string username = default(string), string customId = default(string), string id = default(string), int? createdAt = default(int?))
        {
            Username = username;
            CustomId = customId;
            Id = id;
            CreatedAt = createdAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique username of the consumer. You must send
        /// either this field or custom_id with the request.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets field for storing an existing unique ID for the
        /// consumer - useful for mapping Kong with users in your existing
        /// database. You must send either this field or username with the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// Gets or sets uid.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets unix timestamp of the create action
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public int? CreatedAt { get; set; }

    }
}
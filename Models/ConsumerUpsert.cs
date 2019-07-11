// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConsumerUpsert
    {
        /// <summary>
        /// Initializes a new instance of the ConsumerUpsert class.
        /// </summary>
        public ConsumerUpsert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumerUpsert class.
        /// </summary>
        /// <param name="username">The unique username of the consumer. You
        /// must send either this field or custom_id with the request.</param>
        /// <param name="customId">Field for storing an existing unique ID for
        /// the consumer - useful for mapping Kong with users in your existing
        /// database. You must send either this field or username with the
        /// request.</param>
        public ConsumerUpsert(string username = default(string), string customId = default(string))
        {
            Username = username;
            CustomId = customId;
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

    }
}
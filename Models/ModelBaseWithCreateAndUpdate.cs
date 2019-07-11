// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ModelBaseWithCreateAndUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ModelBaseWithCreateAndUpdate
        /// class.
        /// </summary>
        public ModelBaseWithCreateAndUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelBaseWithCreateAndUpdate
        /// class.
        /// </summary>
        /// <param name="id">Uid.</param>
        /// <param name="createdAt">Unix timestamp of the create action</param>
        /// <param name="updatedAt">Unix timestamp of the last update
        /// action</param>
        public ModelBaseWithCreateAndUpdate(string id = default(string), int? createdAt = default(int?), int? updatedAt = default(int?))
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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

        /// <summary>
        /// Gets or sets unix timestamp of the last update action
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public int? UpdatedAt { get; set; }

    }
}

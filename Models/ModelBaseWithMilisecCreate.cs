// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ModelBaseWithMilisecCreate
    {
        /// <summary>
        /// Initializes a new instance of the ModelBaseWithMilisecCreate class.
        /// </summary>
        public ModelBaseWithMilisecCreate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelBaseWithMilisecCreate class.
        /// </summary>
        /// <param name="id">Uid.</param>
        /// <param name="createdAt">Milisec based timestamp of the create
        /// action</param>
        public ModelBaseWithMilisecCreate(string id = default(string), int? createdAt = default(int?))
        {
            Id = id;
            CreatedAt = createdAt;
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
        /// Gets or sets milisec based timestamp of the create action
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public int? CreatedAt { get; set; }

    }
}

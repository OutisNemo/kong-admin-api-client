// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AclUpsert
    {
        /// <summary>
        /// Initializes a new instance of the AclUpsert class.
        /// </summary>
        public AclUpsert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AclUpsert class.
        /// </summary>
        /// <param name="group">The arbitrary group name to associate to the
        /// consumer.</param>
        public AclUpsert(string group = default(string))
        {
            Group = group;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the arbitrary group name to associate to the consumer.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

    }
}

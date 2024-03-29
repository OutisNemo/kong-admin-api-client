// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CredentialUpsert
    {
        /// <summary>
        /// Initializes a new instance of the CredentialUpsert class.
        /// </summary>
        public CredentialUpsert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialUpsert class.
        /// </summary>
        /// <param name="key">A unique string identifying the
        /// credential.</param>
        public CredentialUpsert(string key = default(string))
        {
            Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a unique string identifying the credential.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

    }
}

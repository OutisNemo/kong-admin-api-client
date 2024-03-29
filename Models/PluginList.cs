// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PluginList
    {
        /// <summary>
        /// Initializes a new instance of the PluginList class.
        /// </summary>
        public PluginList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PluginList class.
        /// </summary>
        /// <param name="data">List of plugins associated to a specific
        /// service.</param>
        /// <param name="next">Url to fetch next part of the plugin
        /// list.</param>
        public PluginList(IList<Plugin> data = default(IList<Plugin>), string next = default(string))
        {
            Data = data;
            Next = next;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of plugins associated to a specific service.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<Plugin> Data { get; set; }

        /// <summary>
        /// Gets or sets url to fetch next part of the plugin list.
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

    }
}

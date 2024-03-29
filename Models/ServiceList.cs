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

    public partial class ServiceList
    {
        /// <summary>
        /// Initializes a new instance of the ServiceList class.
        /// </summary>
        public ServiceList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceList class.
        /// </summary>
        /// <param name="data">List of services.</param>
        /// <param name="next">Url to fetch next part of the service
        /// list.</param>
        public ServiceList(IList<Service> data = default(IList<Service>), string next = default(string))
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
        /// Gets or sets list of services.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<Service> Data { get; set; }

        /// <summary>
        /// Gets or sets url to fetch next part of the service list.
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

    }
}

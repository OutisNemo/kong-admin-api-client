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

    public partial class RouteList
    {
        /// <summary>
        /// Initializes a new instance of the RouteList class.
        /// </summary>
        public RouteList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteList class.
        /// </summary>
        /// <param name="data">List of routes associated to a specific
        /// service.</param>
        /// <param name="next">Url to fetch next part of the route
        /// list.</param>
        public RouteList(IList<Route> data = default(IList<Route>), string next = default(string))
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
        /// Gets or sets list of routes associated to a specific service.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<Route> Data { get; set; }

        /// <summary>
        /// Gets or sets url to fetch next part of the route list.
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

    }
}
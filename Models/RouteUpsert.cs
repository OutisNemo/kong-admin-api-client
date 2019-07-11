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

    public partial class RouteUpsert
    {
        /// <summary>
        /// Initializes a new instance of the RouteUpsert class.
        /// </summary>
        public RouteUpsert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteUpsert class.
        /// </summary>
        /// <param name="name">The name of the Route.</param>
        /// <param name="protocols">A list of the protocols this Route should
        /// allow. When set to ["https"], HTTP requests are answered with a
        /// request to upgrade to HTTPS. Defaults to ["http", "https"].</param>
        /// <param name="methods">A list of HTTP methods that match this Route.
        /// When using http or https protocols, at least one of hosts, paths,
        /// or methods must be set.</param>
        /// <param name="hosts">A list of domain names that match this Route.
        /// When using http or https protocols, at least one of hosts, paths,
        /// or methods must be set. With form-encoded, the notation is
        /// hosts[]=example.com&amp;hosts[]=foo.test. With JSON, use an
        /// Array.</param>
        /// <param name="paths">A list of paths that match this Route. When
        /// using http or https protocols, at least one of hosts, paths, or
        /// methods must be set. With form-encoded, the notation is
        /// paths[]=/foo&amp;paths[]=/bar. With JSON, use an Array.</param>
        /// <param name="regexPriority">A number used to choose which route
        /// resolves a given request when several routes match it using regexes
        /// simultaneously. When two routes match the path and have the same
        /// regex_priority, the older one (lowest created_at) is used. Note
        /// that the priority for non-regex routes is different (longer
        /// non-regex routes are matched before shorter ones).</param>
        /// <param name="stripPath">When matching a Route via one of the paths,
        /// strip the matching prefix from the upstream request URL.</param>
        /// <param name="preserveHost">When matching a Route via one of the
        /// hosts domain names, use the request Host header in the upstream
        /// request headers. If set to false, the upstream Host header will be
        /// that of the Service’s host.</param>
        /// <param name="snis">A list of SNIs that match this Route when using
        /// stream routing. When using tcp or tls protocols, at least one of
        /// snis, sources, or destinations must be set.</param>
        /// <param name="sources">A list of IP sources of incoming connections
        /// that match this Route when using stream routing. Each entry is an
        /// object with fields “ip” (optionally in CIDR range notation) and/or
        /// “port”. When using tcp or tls protocols, at least one of snis,
        /// sources, or destinations must be set.</param>
        /// <param name="destinations">A list of IP destinations of incoming
        /// connections that match this Route when using stream routing. Each
        /// entry is an object with fields “ip” (optionally in CIDR range
        /// notation) and/or “port”. When using tcp or tls protocols, at least
        /// one of snis, sources, or destinations must be set.</param>
        public RouteUpsert(string name = default(string), IList<string> protocols = default(IList<string>), IList<string> methods = default(IList<string>), IList<string> hosts = default(IList<string>), IList<string> paths = default(IList<string>), int? regexPriority = default(int?), bool? stripPath = default(bool?), bool? preserveHost = default(bool?), IList<string> snis = default(IList<string>), IList<string> sources = default(IList<string>), IList<string> destinations = default(IList<string>))
        {
            Name = name;
            Protocols = protocols;
            Methods = methods;
            Hosts = hosts;
            Paths = paths;
            RegexPriority = regexPriority;
            StripPath = stripPath;
            PreserveHost = preserveHost;
            Snis = snis;
            Sources = sources;
            Destinations = destinations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Route.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of the protocols this Route should allow. When
        /// set to ["https"], HTTP requests are answered with a request to
        /// upgrade to HTTPS. Defaults to ["http", "https"].
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<string> Protocols { get; set; }

        /// <summary>
        /// Gets or sets a list of HTTP methods that match this Route. When
        /// using http or https protocols, at least one of hosts, paths, or
        /// methods must be set.
        /// </summary>
        [JsonProperty(PropertyName = "methods")]
        public IList<string> Methods { get; set; }

        /// <summary>
        /// Gets or sets a list of domain names that match this Route. When
        /// using http or https protocols, at least one of hosts, paths, or
        /// methods must be set. With form-encoded, the notation is
        /// hosts[]=example.com&amp;amp;hosts[]=foo.test. With JSON, use an
        /// Array.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }

        /// <summary>
        /// Gets or sets a list of paths that match this Route. When using http
        /// or https protocols, at least one of hosts, paths, or methods must
        /// be set. With form-encoded, the notation is
        /// paths[]=/foo&amp;amp;paths[]=/bar. With JSON, use an Array.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Gets or sets a number used to choose which route resolves a given
        /// request when several routes match it using regexes simultaneously.
        /// When two routes match the path and have the same regex_priority,
        /// the older one (lowest created_at) is used. Note that the priority
        /// for non-regex routes is different (longer non-regex routes are
        /// matched before shorter ones).
        /// </summary>
        [JsonProperty(PropertyName = "regex_priority")]
        public int? RegexPriority { get; set; }

        /// <summary>
        /// Gets or sets when matching a Route via one of the paths, strip the
        /// matching prefix from the upstream request URL.
        /// </summary>
        [JsonProperty(PropertyName = "strip_path")]
        public bool? StripPath { get; set; }

        /// <summary>
        /// Gets or sets when matching a Route via one of the hosts domain
        /// names, use the request Host header in the upstream request headers.
        /// If set to false, the upstream Host header will be that of the
        /// Service’s host.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_host")]
        public bool? PreserveHost { get; set; }

        /// <summary>
        /// Gets or sets a list of SNIs that match this Route when using stream
        /// routing. When using tcp or tls protocols, at least one of snis,
        /// sources, or destinations must be set.
        /// </summary>
        [JsonProperty(PropertyName = "snis")]
        public IList<string> Snis { get; set; }

        /// <summary>
        /// Gets or sets a list of IP sources of incoming connections that
        /// match this Route when using stream routing. Each entry is an object
        /// with fields “ip” (optionally in CIDR range notation) and/or “port”.
        /// When using tcp or tls protocols, at least one of snis, sources, or
        /// destinations must be set.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<string> Sources { get; set; }

        /// <summary>
        /// Gets or sets a list of IP destinations of incoming connections that
        /// match this Route when using stream routing. Each entry is an object
        /// with fields “ip” (optionally in CIDR range notation) and/or “port”.
        /// When using tcp or tls protocols, at least one of snis, sources, or
        /// destinations must be set.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<string> Destinations { get; set; }

    }
}

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kong.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Service
    {
        /// <summary>
        /// Initializes a new instance of the Service class.
        /// </summary>
        public Service()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Service class.
        /// </summary>
        /// <param name="name">The Service name.</param>
        /// <param name="retries">The number of retries to execute upon failure
        /// to proxy. Defaults to 5.</param>
        /// <param name="protocol">The protocol used to communicate with the
        /// upstream. It can be one of http or https. Possible values include:
        /// 'http', 'https'</param>
        /// <param name="host">The host of the upstream server.</param>
        /// <param name="port">The upstream server port.</param>
        /// <param name="path">The path to be used in requests to the upstream
        /// server.</param>
        /// <param name="connectTimeout">The timeout in milliseconds for
        /// establishing a connection to the upstream server.</param>
        /// <param name="writeTimeout">The timeout in milliseconds between two
        /// successive write operations for transmitting a request to the
        /// upstream server.</param>
        /// <param name="readTimeout">The timeout in milliseconds between two
        /// successive read operations for transmitting a request to the
        /// upstream server.</param>
        /// <param name="id">Uid.</param>
        /// <param name="createdAt">Unix timestamp of the create action</param>
        /// <param name="updatedAt">Unix timestamp of the last update
        /// action</param>
        public Service(string name = default(string), int? retries = default(int?), string protocol = default(string), string host = default(string), int? port = default(int?), string path = default(string), int? connectTimeout = default(int?), int? writeTimeout = default(int?), int? readTimeout = default(int?), string id = default(string), int? createdAt = default(int?), int? updatedAt = default(int?))
        {
            Name = name;
            Retries = retries;
            Protocol = protocol;
            Host = host;
            Port = port;
            Path = path;
            ConnectTimeout = connectTimeout;
            WriteTimeout = writeTimeout;
            ReadTimeout = readTimeout;
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
        /// Gets or sets the Service name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of retries to execute upon failure to
        /// proxy. Defaults to 5.
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// Gets or sets the protocol used to communicate with the upstream. It
        /// can be one of http or https. Possible values include: 'http',
        /// 'https'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the host of the upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the upstream server port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the path to be used in requests to the upstream
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the timeout in milliseconds for establishing a
        /// connection to the upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "connect_timeout")]
        public int? ConnectTimeout { get; set; }

        /// <summary>
        /// Gets or sets the timeout in milliseconds between two successive
        /// write operations for transmitting a request to the upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "write_timeout")]
        public int? WriteTimeout { get; set; }

        /// <summary>
        /// Gets or sets the timeout in milliseconds between two successive
        /// read operations for transmitting a request to the upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "read_timeout")]
        public int? ReadTimeout { get; set; }

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
// ReSharper disable CheckNamespace
namespace Kong.Models
{
    using System;
    using Newtonsoft.Json;

    public partial class Route : ModelBaseWithDate
    {
        [JsonIgnore]
        public DateTime? CreatedDate
        {
            get => ConvertFromUnixTimestamp(CreatedAt);
            set => CreatedAt = ConvertToUnixTimestamp(value);
        }

        [JsonIgnore]
        public DateTime? UpdatedDate
        {
            get => ConvertFromUnixTimestamp(UpdatedAt);
            set => UpdatedAt = ConvertToUnixTimestamp(value);
        }
    }
}

﻿// ReSharper disable CheckNamespace
namespace Kong.Models
{
    using System;
    using Newtonsoft.Json;

    public partial class ModelBaseWithMilisecCreate : ModelBaseWithDate
    {
        [JsonIgnore]
        public DateTime? CreatedDate
        {
            get => ConvertFromUnixTimestamp(CreatedAt);
            set => CreatedAt = ConvertToUnixTimestamp(value);
        }
    }
}

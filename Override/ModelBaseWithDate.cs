// ReSharper disable CheckNamespace
namespace Kong.Models
{
    using System;

    public abstract class ModelBaseWithDate
    {
        protected static DateTime? ConvertFromUnixTimestamp(int? timestamp)
        {
            if (timestamp == null)
            {
                return null;
            }

            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp.Value);
        }

        protected static int? ConvertToUnixTimestamp(DateTime? date)
        {
            if (date == null)
            {
                return null;
            }

            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var diff = date.Value.ToUniversalTime() - origin;
            return (int)Math.Floor(diff.TotalSeconds);
        }
    }
}

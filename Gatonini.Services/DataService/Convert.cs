using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Gatonini.Services
{
    public partial class Convert<T>
    {
        public static T[] FromJson(string json) => JsonConvert.DeserializeObject<T[]>(json, Converter.Settings);
    }

    public partial class ConvertGrouped<T>
    {
        public static List<T[]> FromJson(string json) => JsonConvert.DeserializeObject<List<T[]>>(json, Converter.Settings);
    }

    public partial class ConvertSingle<T>
    {
        public static T FromJson(string json) => JsonConvert.DeserializeObject<T>(json, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

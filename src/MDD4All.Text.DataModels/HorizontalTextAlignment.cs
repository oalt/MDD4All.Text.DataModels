﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace MDD4All.Text.DataModels
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HorizontalTextAlignment
    {
        Left,
        Center,
        Right,

    }
}

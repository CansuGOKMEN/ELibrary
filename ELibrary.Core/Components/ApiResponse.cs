using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Components
{
    public class ApiResponse
    {
        public bool success { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public dynamic data { get; set; }
        public int statusCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage { get; set; }

        public ApiResponse()
        {
            success = false;
            data = null;
            statusCode = 200;
            errorMessage = null;
        }
        public ApiResponse(dynamic resposeData)
        {
            success = false;
            data = resposeData;
            statusCode = 200;
            errorMessage = null;
        }
    }
}

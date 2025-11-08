using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("daysToExpiration")]
        public int DaysToExpiration { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("daysSinceLastUpdate")]
        public int DaysSinceLastUpdate { get; set; }

        [JsonProperty("domainAgeDays")]
        public int DomainAgeDays { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}

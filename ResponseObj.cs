using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("createdDate")]
    public DateTime createdDate { get; set; }

    [JsonProperty("daysSinceLastUpdate")]
    public int daysSinceLastUpdate { get; set; }

    [JsonProperty("daysToExpiration")]
    public int daysToExpiration { get; set; }

    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("domainAgeDays")]
    public int domainAgeDays { get; set; }

    [JsonProperty("expirationDate")]
    public DateTime expirationDate { get; set; }

    [JsonProperty("lastUpdatedDate")]
    public DateTime lastUpdatedDate { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}

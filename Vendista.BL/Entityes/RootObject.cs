using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Vendista.BL.Entityes;





public class RootObject
{
    [JsonProperty("total")]
    [JsonPropertyName("total")]
    public total total { get; set; }
    [JsonProperty("page_number")]
    [JsonPropertyName("page_number")]
    public int page_number { get; set; }
    [JsonProperty("items_per_page")]
    [JsonPropertyName("items_per_page")]
    public int items_per_page { get; set; }
    [JsonProperty("items_count")]
    [JsonPropertyName("items_count")]
    public int items_count { get; set; }
    [JsonProperty("items")]
    [JsonPropertyName("items")]
    public List<items> items { get; set; }
    [JsonProperty("success")]
    [JsonPropertyName("success")]
    public bool success { get; set; }
}
public class total
{
    [JsonProperty("working")]
    [JsonPropertyName("working")]
    public int working { get; set; }
    [JsonProperty("failed")]
    [JsonPropertyName("failed")]
    public int failed { get; set; }
    [JsonProperty("warning")]
    [JsonPropertyName("warning")]
    public int warning { get; set; }
}

public class items
{
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string name { get; set; }
    [JsonProperty("model")]
    [JsonPropertyName("model")]
    public string model { get; set; }
    [JsonProperty("model_id")]
    [JsonPropertyName("model_id")]
    public int model_id { get; set; }
    [JsonProperty("address")]
    [JsonPropertyName("address")]
    public string address { get; set; }
    [JsonProperty("number")]
    [JsonPropertyName("number")]
    public object number { get; set; }
    [JsonProperty("terminal_id")]
    [JsonPropertyName("terminal_id")]
    public object terminal_id { get; set; }
    [JsonProperty("state_id")]
    [JsonPropertyName("state_id")]
    public int state_id { get; set; }
    [JsonProperty("product_matrix_id")]
    [JsonPropertyName("product_matrix_id")]
    public object product_matrix_id { get; set; }
    [JsonProperty("daily_sales_sum")]
    [JsonPropertyName("daily_sales_sum")]
    public int daily_sales_sum { get; set; }
    [JsonProperty("daily_sales_count")]
    [JsonPropertyName("daily_sales_count")]
    public int daily_sales_count { get; set; }
    [JsonProperty("last_sale")]
    [JsonPropertyName("last_sale")]
    public string last_sale { get; set; }
    [JsonProperty("state_mask")]
    [JsonPropertyName("state_mask")]
    public int state_mask { get; set; }
    [JsonProperty("micromarket")]
    [JsonPropertyName("micromarket")]
    public bool micromarket { get; set; }
    [JsonProperty("product_matrix_version")]
    [JsonPropertyName("product_matrix_version")]
    public int product_matrix_version { get; set; }
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int id { get; set; }
}









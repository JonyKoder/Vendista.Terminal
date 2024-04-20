using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Vendista.BL.Entityes;

public class CommandModel
{
   
    [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("page_number")]
    public int page_number { get; set; }
    [JsonProperty("items_per_page", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("items_per_page")]
    public int items_per_page { get; set; }
    [JsonProperty("items_count", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("items_count")]
    public int items_count { get; set; }
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("items")]
    public List<items> items { get; set; }
    [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("success")]
    public bool success { get; set; }
}

public class CommandType
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int id { get; set; }
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string name { get; set; }
    [JsonProperty("parameter_name1", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name1")]
    public object parameter_name1 { get; set; }
    [JsonProperty("parameter_name2", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name2")]
    public object parameter_name2 { get; set; }
    [JsonProperty("parameter_name3", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name3")]
    public object parameter_name3 { get; set; }
    [JsonProperty("parameter_name4", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name4")]
    public object parameter_name4 { get; set; }
    [JsonProperty("parameter_name5", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name5")]
    public object parameter_name5 { get; set; }
    [JsonProperty("parameter_name6", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name6")]
    public object parameter_name6 { get; set; }
    [JsonProperty("parameter_name7", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name7")]
    public object parameter_name7 { get; set; }
    [JsonProperty("parameter_name8", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_name8")]
    public object parameter_name8 { get; set; }
    [JsonProperty("str_parameter_name1", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("str_parameter_name1")]
    public object str_parameter_name1 { get; set; }
    [JsonProperty("str_parameter_name2", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("str_parameter_name2")]
    public object str_parameter_name2 { get; set; }
    [JsonProperty("parameter_default_value1", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value1")]
    public object parameter_default_value1 { get; set; }
    [JsonProperty("parameter_default_value2", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value2")]
    public object parameter_default_value2 { get; set; }
    [JsonProperty("parameter_default_value3", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value3")]
    public object parameter_default_value3 { get; set; }
    [JsonProperty("parameter_default_value4", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value4")]
    public object parameter_default_value4 { get; set; }
    [JsonProperty("parameter_default_value5", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value5")]
    public object parameter_default_value5 { get; set; }
    [JsonProperty("parameter_default_value6", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value6")]
    public object parameter_default_value6 { get; set; }
    [JsonProperty("parameter_default_value7", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value7")]
    public object parameter_default_value7 { get; set; }
    [JsonProperty("parameter_default_value8", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("parameter_default_value8")]
    public object parameter_default_value8 { get; set; }
    [JsonProperty("str_parameter_default_value1", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("str_parameter_default_value1")]
    public object str_parameter_default_value1 { get; set; }
    [JsonProperty("str_parameter_default_value2", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("str_parameter_default_value2")]
    public object str_parameter_default_value2 { get; set; }
    [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("visible")]
    public bool visible { get; set; }
}



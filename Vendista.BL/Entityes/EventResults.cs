using System.Text.Json.Serialization;

namespace Vendista.BL.Entityes
{

public class EventResults
{
    [JsonPropertyName("total")]
    public totalEvent total { get; set; }
    [JsonPropertyName("page_number")]
    public int page_number { get; set; }
    [JsonPropertyName("items_per_page")]
    public int items_per_page { get; set; }
    [JsonPropertyName("items_count")]
    public int items_count { get; set; }
    [JsonPropertyName("items")]
    public List<itemsEvents> items { get; set; }
    [JsonPropertyName("success")]
    public bool success { get; set; }
}
public class totalEvent
{
    [JsonPropertyName("sum")]
    public int sum { get; set; }
}

public class itemsEvents
{
    [JsonPropertyName("machine_id")]
    public int machine_id { get; set; }
    [JsonPropertyName("machine_name")]
    public string machine_name { get; set; }
    [JsonPropertyName("machine_address")]
    public string machine_address { get; set; }
    [JsonPropertyName("machine_model")]
    public string machine_model { get; set; }
    [JsonPropertyName("event_name")]
    public string event_name { get; set; }
    [JsonPropertyName("product_name")]
    public string product_name { get; set; }
    [JsonPropertyName("sum")]
    public int sum { get; set; }
    [JsonPropertyName("date")]
    public string date { get; set; }
    [JsonPropertyName("dateID")]
    public int dateID { get; set; }
    [JsonPropertyName("division_name")]
    public string division_name { get; set; }
}

    
}
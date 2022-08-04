using System.Text.Json.Serialization;

public class Dashboard
{
    [JsonIgnore]
    public const string SectionName = "Dashboard"; // Section Name to bind to app settings Section

    public string ApplicationUrl { get; set; } = String.Empty;

}
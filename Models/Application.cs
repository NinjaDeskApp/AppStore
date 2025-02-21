namespace AppStore.Models;

public class Application
{
    public required string DisplayName { get; set; }
    public required string Author { get; set; }
    public required string Version { get; set; }
    public string? Icon { get; set; }
    public List<string>? Snapshots { get; set; }
}
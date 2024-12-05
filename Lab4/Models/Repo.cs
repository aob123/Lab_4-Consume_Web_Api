using System.Text.Json.Serialization;

public class Repo
{
    [property: JsonPropertyName("name")]
    public string? Name {get; set;}

    [property: JsonPropertyName("description")]
    public string? Description {get; set;}

    [property: JsonPropertyName("html_url")]
    public string? html_url {get; set;}

    [property: JsonPropertyName("homepage")]
    public string? Homepage {get; set;}
    
    [property: JsonPropertyName("watchers")]
    public int Watchers {get; set;}

    [property: JsonPropertyName("pushed_at")]
    public DateTime Pushed_at {get; set;}


    public override string ToString()
    {
        return $"Name: {this.Name} \n Description: {this.Description} \n Url: {this.html_url} \n Homepage: {this.Homepage} \n Watchers: {this.Watchers} \n Pushed: {this.Pushed_at}";
    }

}
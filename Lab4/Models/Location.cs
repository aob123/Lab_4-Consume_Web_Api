using System.Text.Json.Serialization;

public class Location
{

    [property: JsonPropertyName("country abbreviation")]
    public string? Country_Abb { get; set; }
    public List<Place>? Places { get; set; }


    [property: JsonPropertyName("country")]
    public string? Country { get; set; }

    [property: JsonPropertyName("place name")]
    public string? Place_Name { get; set; }

    [property: JsonPropertyName("state")]
    public string? State { get; set; }

    [property: JsonPropertyName("state abbreviation")]
    public string? State_Abb { get; set; }

    public override string ToString()
    {
        return $"Location: \nCountry Abbreviation: {this.Country_Abb} \nCountry: {this.Country} \nPlace Name: {this.Place_Name} \nState: {this.State} \nState Abbreviation: {this.State_Abb}\n";
    }
}

public class Place
{
    [property: JsonPropertyName("place name")]
    public string? Place_Name { get; set; }

    [property: JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [property: JsonPropertyName("post code")]
    public string? Post_Code { get; set; }

    [property: JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    public override string ToString()
    {
        return $"Places: \nPlace Name: {this.Place_Name} \nPost Code: {this.Post_Code}\nLongitude: {this.Longitude} \nLatitude: {this.Latitude} \n";
    }
}
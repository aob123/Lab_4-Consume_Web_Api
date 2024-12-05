using System.Diagnostics;
using System.Net;
using System.Text.Json;

public class LocationService
{
    public async Task GetLocation(string country, string state, string city)
    {
        // Example: api.zippopotam.us/us/ma/belmont
        var location = $"{country}/{state}/{city}";
        HttpClient client = new();

        try
        {
            client.DefaultRequestHeaders.Add("User-Agent", "aob123");
            var url = new Uri("https://api.zippopotam.us/" + location);
            var response = await client.GetStringAsync(url);

            var locationInfo = JsonSerializer.Deserialize<Location>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            if (locationInfo?.Places != null)
            {
                foreach (var place in locationInfo.Places)
                {
                    Console.WriteLine(place);
                }
            }

            Console.WriteLine(locationInfo);


        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}


using System.Text.Json;
HttpClient client = new();

try
{
    client.DefaultRequestHeaders.Add("User-Agent", "aob123");
    var url = new Uri("https://api.github.com/orgs/dotnet/repos");
    var response = await client.GetStringAsync(url);
    int counter = 0;
    var repos = JsonSerializer.Deserialize<List<Repo>>(response);

    foreach (var repo in repos)
    {
        counter++;
        Console.WriteLine($"#{counter} \n {repo}");
    }

}
catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}


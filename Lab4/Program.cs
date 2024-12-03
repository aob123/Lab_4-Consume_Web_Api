
using System.Text.Json;

HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("User-Agent", "aob123");
var url = new Uri("https://api.github.com/orgs/dotnet/repos");
int counter = 0;

try
{
    var response = await client.GetStringAsync(url);
    var repos = JsonSerializer.Deserialize<List<Repo>>(response);

    foreach (var repo in repos)
    {
        counter++;
        Console.WriteLine($"Number: {counter}");
        Console.WriteLine($"Name: {repo.Name} \n Description: {repo.Description} \n url: {repo.html_url} \n homepage: {repo.Homepage} \n watchers: {repo.Watchers} \n pushed: {repo.Pushed_at} \n\n");

    }

}
catch (Exception e)
{
    
    Console.WriteLine($"Error: {e.Message}");
}


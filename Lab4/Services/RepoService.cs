using System.Text.Json;

public class RepoService
{
    public async Task GetRepos()
    {

        HttpClient client = new();

        try
        {
            client.DefaultRequestHeaders.Add("User-Agent", "aob123");
            var url = new Uri("https://api.github.com/orgs/dotnet/repos");
            var response = await client.GetStringAsync(url);
            var repos = JsonSerializer.Deserialize<List<Repo>>(response);

            foreach (var repo in repos)
            {
                Console.WriteLine($"{repo} \n");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}


internal class Program
{
    private static async Task Main(string[] args)
    {
        var repoService = new RepoService();
        await repoService.GetRepos();
        var locationService = new LocationService();
        await locationService.GetLocation("us", "nj", "montvale");
    }
}
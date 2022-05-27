using System.Net;

namespace Web.Data;

public class ScheduleService
{
    private readonly HttpClient _httpClient = new();

    public ScheduleService()
    {
        _httpClient.BaseAddress = new Uri("https://snokinghockeyleague.com");
    }

    public async Task<List<SnokingGame>> GetGames(int seasonId, int teamId)
    {
        var result = await _httpClient.GetAsync($"/api/team/subSchedule/{seasonId}/{teamId}?v=1028850");
        result.EnsureSuccessStatusCode();
        var schedule = await result.Content.ReadFromJsonAsync<SnokingScheduleResponse>();
        return schedule?.Games ?? new List<SnokingGame>();
    }
}

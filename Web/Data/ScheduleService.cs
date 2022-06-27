using System.Net.Http.Json;

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
        var result = await _httpClient.GetAsync($"api/team/subSchedule/{seasonId}/{teamId}?v=1028850");
        result.EnsureSuccessStatusCode();
        var schedule = await result.Content.ReadFromJsonAsync<SnokingScheduleResponse>();
        return schedule?.Games ?? new List<SnokingGame>();
    }

    public async Task<List<Season>> GetSeasons()
    {
        var result = await _httpClient.GetAsync($"/api/season/all/0?v=1030940");
        result.EnsureSuccessStatusCode();

        var seasons = await result.Content.ReadFromJsonAsync<SnokingSeasonsResponse>();
        return seasons?.Seasons ?? new List<Season>();
    }
    
    public async Task<List<Team>> GetTeams(int seasonId)
    {
        var result = await _httpClient.GetAsync($"api/team/list/{seasonId}/0?v=1030940");
        result.EnsureSuccessStatusCode();

        var seasons = await result.Content.ReadFromJsonAsync<List<Team>>();
        return seasons ?? new List<Team>();
    }
}

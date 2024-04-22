using Schedule.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServerSideBlazor();

var app = builder.Build();

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://snokinghockeyleague.com");

app.MapGet("download/{seasonId}/{teamId}", async (int teamId, int seasonId) =>
{
    var result = await httpClient.GetAsync($"/api/team/subSchedule/{seasonId}/{teamId}?v=1028850");
    result.EnsureSuccessStatusCode();
    var schedule = await result.Content.ReadFromJsonAsync<ScheduleResponse>();

    await using var fileStream = new StreamWriter(@"c:\Users\Chase Dog\Documents\schedule.csv");
    foreach (var game in schedule.Games)
    {
        var home = game.TeamHomeName;
        var away = game.TeamAwayName;
        await fileStream.WriteLineAsync(string.Join(",", "GAME", "PLAYOFF", "", home, away, game.DateTime.ToString("dd/MM/yyy"), game.DateTime.ToString("h:mm:ss tt"), "1:15", game.RinkName));
    }
});

app.MapBlazorHub();
app.Run();
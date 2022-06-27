using System.Text.Json.Serialization;

namespace Web.Data;

    public class Profile
    {
        [JsonPropertyName("Stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("TeamColors")]
        public string TeamColors { get; set; }

        [JsonPropertyName("LogoUrl")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("PhotoUrl")]
        public string PhotoUrl { get; set; }

        [JsonPropertyName("PhotoComment")]
        public string PhotoComment { get; set; }
    }

    public class Team
    {
        [JsonPropertyName("seasonId")]
        public int SeasonId { get; set; }

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("divisionId")]
        public int DivisionId { get; set; }

        [JsonPropertyName("divisionName")]
        public string DivisionName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("teamColors")]
        public string TeamColors { get; set; }

        [JsonPropertyName("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("photoUrl")]
        public string PhotoUrl { get; set; }

        [JsonPropertyName("photoComment")]
        public string PhotoComment { get; set; }

        [JsonPropertyName("Profile")]
        public Profile Profile { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class Stats
    {
        [JsonPropertyName("GP")]
        public int GP { get; set; }

        [JsonPropertyName("W")]
        public int W { get; set; }

        [JsonPropertyName("L")]
        public int L { get; set; }

        [JsonPropertyName("T")]
        public int T { get; set; }

        [JsonPropertyName("PTS")]
        public int PTS { get; set; }

        [JsonPropertyName("GF")]
        public int GF { get; set; }

        [JsonPropertyName("GA")]
        public int GA { get; set; }

        [JsonPropertyName("PIM")]
        public int PIM { get; set; }

        [JsonPropertyName("Last5")]
        public string Last5 { get; set; }

        [JsonPropertyName("Streak")]
        public string Streak { get; set; }
    }

    public class Stats2
    {
        [JsonPropertyName("GP")]
        public int GP { get; set; }

        [JsonPropertyName("W")]
        public int W { get; set; }

        [JsonPropertyName("L")]
        public int L { get; set; }

        [JsonPropertyName("T")]
        public int T { get; set; }

        [JsonPropertyName("PTS")]
        public int PTS { get; set; }

        [JsonPropertyName("GF")]
        public int GF { get; set; }

        [JsonPropertyName("GA")]
        public int GA { get; set; }

        [JsonPropertyName("PIM")]
        public int PIM { get; set; }

        [JsonPropertyName("Last5")]
        public string Last5 { get; set; }

        [JsonPropertyName("Streak")]
        public string Streak { get; set; }
    }

public class SnokingTeamsResponse
{
    [JsonPropertyName("teams")]
    public List<Team>? Teams { get; set; }
}

// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
public class Season
{
    [JsonPropertyName("leagueId")]
    public int LeagueId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("format")]
    public int Format { get; set; }

    [JsonPropertyName("jersey")]
    public int Jersey { get; set; }

    [JsonPropertyName("period1")]
    public int Period1 { get; set; }

    [JsonPropertyName("period2")]
    public int Period2 { get; set; }

    [JsonPropertyName("period3")]
    public int Period3 { get; set; }

    [JsonPropertyName("overtime")]
    public int Overtime { get; set; }

    [JsonPropertyName("copyFromId")]
    public int CopyFromId { get; set; }

    [JsonPropertyName("copyDivs")]
    public bool CopyDivs { get; set; }

    [JsonPropertyName("copyTeams")]
    public bool CopyTeams { get; set; }

    [JsonPropertyName("copyPlayers")]
    public bool CopyPlayers { get; set; }

    [JsonPropertyName("toDisplay")]
    public bool ToDisplay { get; set; }

    [JsonPropertyName("isArchived")]
    public bool IsArchived { get; set; }

    [JsonPropertyName("isRegistering")]
    public bool IsRegistering { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class SnokingSeasonsResponse
{
    [JsonPropertyName("seasons")]
    public List<Season>? Seasons { get; set; }
}
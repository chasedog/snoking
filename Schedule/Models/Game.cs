using System.Text.Json.Serialization;

namespace Schedule.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Game
{
    [JsonPropertyName("seasonId")]
    public int SeasonId { get; set; }

    [JsonPropertyName("dateTime")]
    public DateTime DateTime { get; set; }

    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("day")]
    public string Day { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("rinkId")]
    public int RinkId { get; set; }

    [JsonPropertyName("rinkName")]
    public string RinkName { get; set; }

    [JsonPropertyName("division")]
    public string Division { get; set; }

    [JsonPropertyName("teamHomeId")]
    public int TeamHomeId { get; set; }

    [JsonPropertyName("teamAwayId")]
    public int TeamAwayId { get; set; }

    [JsonPropertyName("teamHomeName")]
    public string TeamHomeName { get; set; }

    [JsonPropertyName("teamAwayName")]
    public string TeamAwayName { get; set; }

    [JsonPropertyName("teamHomeNameStat")]
    public object TeamHomeNameStat { get; set; }

    [JsonPropertyName("teamAwayNameStat")]
    public object TeamAwayNameStat { get; set; }

    [JsonPropertyName("opponentName")]
    public object OpponentName { get; set; }

    [JsonPropertyName("scoreHome")]
    public object ScoreHome { get; set; }

    [JsonPropertyName("scoreAway")]
    public object ScoreAway { get; set; }

    [JsonPropertyName("score")]
    public object Score { get; set; }

    [JsonPropertyName("isScoresheetSet")]
    public bool IsScoresheetSet { get; set; }

    [JsonPropertyName("isRostersSet")]
    public bool IsRostersSet { get; set; }

    [JsonPropertyName("scoresheet")]
    public object Scoresheet { get; set; }

    [JsonPropertyName("teamHomeSeasonId")]
    public int TeamHomeSeasonId { get; set; }

    [JsonPropertyName("teamAwaySeasonId")]
    public int TeamAwaySeasonId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ScheduleResponse
{
    [JsonPropertyName("games")]
    public List<Game> Games { get; set; }
}


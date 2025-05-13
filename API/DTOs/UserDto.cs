namespace API;

public class userDto
{
    public required string username {get; set; }
    public required string? knownAs {get; set; }
    public required string token {get; set; }
    public required string Gender {get; set; }
    public string? PhotoUrl {get; set; }
}
namespace res.Models;

public class Highscore : Repo_Item<int>
{
    public string ProfileID { get; set; }
    public int GameID { get; set; }
    public int Score { get; set; }
}
namespace res.Models;

public class Profile : Repo_Item<string>
{
  public string Name { get; set; }
  public string Picture { get; set; }
}

public class Account : Profile
{
  public string Email { get; set; }
}
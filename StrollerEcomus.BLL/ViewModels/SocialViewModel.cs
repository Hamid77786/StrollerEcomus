

namespace StrollerEcomus.BLL.ViewModels;

public class SocialViewModel
{
    public int Id { get; set; }
    public string? IconName { get; set; }
    public string? IconClass { get; set; }
}

public class CreateSocialViewModel
{
    public string? IconName { get; set; }
    public string? IconClass { get; set; }
}

public class UpdateSocialViewModel
{
    public int Id { get; set; }
    public string? IconName { get; set; }
    public string? IconClass { get; set; }
}

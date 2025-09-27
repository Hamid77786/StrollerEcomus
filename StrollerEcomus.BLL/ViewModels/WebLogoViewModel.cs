

namespace StrollerEcomus.BLL.ViewModels;

public class WebLogoViewModel
{
    public int Id { get; set; }
    public string? WebLogoName { get; set; }
    public string? WebLogoImgUrl { get; set; }
}

public class CreateWebLogoViewModel
{
    public string? WebLogoName { get; set; }
    public string? WebLogoImgUrl { get; set; }
}

public class UpdateWebLogoViewModel
{
    public int Id { get; set; }
    public string? WebLogoName { get; set; }
    public string? WebLogoImgUrl { get; set; }
}

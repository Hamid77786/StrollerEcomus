

namespace StrollerEcomus.BLL.ViewModels;

public class SiteBannerViewModel
{
    public int Id { get; set; }
    public string? BannerImgUrl { get; set; }
    public string? BannerTitle { get; set; }
    public string? BannerContent { get; set; }
}

public class CreateSiteBannerViewModel
{
    
    public string? BannerImgUrl { get; set; }
    public string? BannerTitle { get; set; }
    public string? BannerContent { get; set; }
}

public class UpdateSiteBannerViewModel
{
    public int Id { get; set; }
    public string? BannerImgUrl { get; set; }
    public string? BannerTitle { get; set; }
    public string? BannerContent { get; set; }
}

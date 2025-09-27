

namespace StrollerEcomus.BLL.ViewModels;

public class RecommendationBannerViewModel
{
    public int Id { get; set; }
    public string? RecTitle { get; set; }
    public string? RecDescription { get; set; }
    public string? RecImageUrl { get; set; }
}

public class CreateRecommendationBannerViewModel
{
    public string? RecTitle { get; set; }
    public string RecDescription { get; set; } = null!;
    public string? RecImageUrl { get; set; }
}

public class UpdateRecommendationBannerViewModel
{
    public int Id { get; set; }
    public string? RecTitle { get; set; }
    public string? RecDescription { get; set; }
    public string? RecImageUrl { get; set; }

}
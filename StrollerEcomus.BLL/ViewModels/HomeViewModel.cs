

namespace StrollerEcomus.BLL.ViewModels
{
    public class HomeViewModel 
    {
        public ICollection<SliderViewModel> Sliders { get; set; } = [];
        public ICollection<IconViewModel> Icons { get; set; } = [];
        public ICollection<CategoryViewModel> Categories { get; set; } = [];
        public ICollection<SiteBannerViewModel> SiteBanners { get; set; } = [];
        public ICollection<BrandLogoViewModel> BrandLogos { get; set; } = [];
        public ICollection<ProductViewModel> Products { get; set; } = [];
        public ICollection<ProductImageViewModel> ProductImages { get; set; } = [];
        public ICollection<RecommendationBannerViewModel> RecommendationBanners { get; set; } = [];
        public ICollection<FrequentlyQuestionViewModel> FrequentlyQuestions { get; set; } = [];
        public ICollection<ReviewViewModel> Reviews { get; set; } = [];


       
    }
}
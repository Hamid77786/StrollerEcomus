

using Microsoft.AspNetCore.Http;

namespace StrollerEcomus.BLL.ViewModels;

public class SliderViewModel
{
    public int Id { get; set; }
    public string? SliderImgUrl { get; set; }
    public string? SliderTitle { get; set; }
    public string? SliderContent { get; set; }
}

public class CreateSliderViewModel
{
    public IFormFile SliderImageFile { get; set; } = null!;
    public string? SliderTitle { get; set; }
    public string? SliderContent { get; set; }

    
}

public class UpdateSliderViewModel
{
    public int Id { get; set; }
    public string? ExistingSliderImgUrl { get; set; }
    public IFormFile? NewSliderImageFile { get; set; }
    public string? SliderTitle { get; set; }
    public string? SliderContent { get; set; }

}
    
    


        
    

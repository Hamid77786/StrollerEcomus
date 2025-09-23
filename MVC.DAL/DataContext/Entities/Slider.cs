

using Microsoft.AspNetCore.Http;

namespace StrollerEcomus.DAL.DataContext.Entities;

public class Slider : Entity
{
    public string? SliderImgUrl { get; set; }
   
    public string? SliderTitle { get; set; }
    public string? SliderContent { get; set; }
}



using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.ViewModels;

public class ReviewViewModel
{
    public int Id { get; set; }
    public string? ReviewContent { get; set; }
    public string? ReviewImageUrl { get; set; }
}

public class CreateReviewViewModel
{
   
    public string? ReviewContent { get; set; }
    public string? ReviewImageUrl { get; set; }

}
public class UpdateReviewViewModel
{
    public int Id { get; set; }
    public string? ReviewContent { get; set; }
    public string? ReviewImageUrl { get; set; }
}


namespace StrollerEcomus.DAL.DataContext.Entities;

public class Icon : Entity
{
    public string? IconName { get; set; }
    public string? IconImgUrl { get; set; }
   
    public int IconCategoryId { get; set; }
    public IconCategory? IconCategory { get; set; }

}



using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class PromoUsageViewModel
{
    public int Id { get; set; }
    public DateTime UsedAt { get; set; }
    public int PromoCodeId { get; set; }
    public string PromoCode { get; set; } = null!; 
    public string? AppUserId { get; set; }
    public string? AppUserName { get; set; }
}

public class CreatePromoUsageViewModel
{
    public int PromoCodeId { get; set; }
    public IEnumerable<SelectListItem>? PromoCodes { get; set; }
    public string? AppUserId { get; set; }
    public IEnumerable<SelectListItem>? Users { get; set; }
    public DateTime UsedAt { get; set; } = DateTime.Now;
}

public class UpdatePromoUsageViewModel
{

    public int Id { get; set; }
    public int PromoCodeId { get; set; }
    public IEnumerable<SelectListItem>? PromoCodes { get; set; }
    public string? AppUserId { get; set; }
    public IEnumerable<SelectListItem>? Users { get; set; }
    public DateTime UsedAt { get; set; }

}











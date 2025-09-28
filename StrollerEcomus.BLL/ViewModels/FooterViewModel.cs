

namespace StrollerEcomus.BLL.ViewModels;

public class FooterViewModel
{
    public ICollection<WebLogoViewModel> WebLogos { get; set; } = [];
    public ICollection<SocialViewModel> Socials { get; set; } = [];
    public ICollection<WebInfoViewModel> WebInfos { get; set; } = [];
    public ICollection<LanguageViewModel> Languages { get; set; } = [];
    public ICollection<CurrencyViewModel> Currencies { get; set; } = [];
    public ICollection<PaymentImageViewModel> PaymentImages { get; set; } = [];

}

using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services;

public class FooterManager : IFooterService
{
    private readonly IWebLogoService _webLogoService;
    private readonly ISocialService _socialService;
    private readonly IWebInfoService _webInfoService;
    private readonly ILanguageService _languageService;
    private readonly ICurrencyService _currencyService;
    private readonly IPaymentImageService _paymentImageService;

    public FooterManager
                      (IWebLogoService webLogoService, 
                        ISocialService socialService, 
                        IWebInfoService webInfoService,
                        ILanguageService languageService, 
                        ICurrencyService currencyService, 
                        IPaymentImageService paymentImageService)
    
    {
        _webLogoService = webLogoService;
        _socialService = socialService;
        _webInfoService = webInfoService;
        _languageService = languageService;
        _currencyService = currencyService;
        _paymentImageService = paymentImageService;
    }

    public async Task<FooterViewModel> GetFooterViewModel()
    {
        var webLogos = await _webLogoService.GetAllAsync();
        var socials = await _socialService.GetAllAsync();
        var webInfos = await _webInfoService.GetAllAsync();
        var languages = await _languageService.GetAllAsync();
        var currencies = await _currencyService.GetAllAsync();
        var paymentImages = await _paymentImageService.GetAllAsync();

        var footerViewModel = new FooterViewModel
        {
            WebLogos = webLogos.ToList(),
            Socials = socials.ToList(),
            WebInfos = webInfos.ToList(),
            Languages = languages.ToList(),
            Currencies = currencies.ToList(),
            PaymentImages = paymentImages.ToList(),
        };

        return footerViewModel;
    }
}

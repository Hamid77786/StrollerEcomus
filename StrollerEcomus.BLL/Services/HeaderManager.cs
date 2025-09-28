

using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;

namespace StrollerEcomus.BLL.Services;

public class HeaderManager : IHeaderService
{
    private readonly IWebLogoService _webLogoService;
    private readonly IIconService _iconService;

    public HeaderManager(IWebLogoService webLogoService,IIconService iconService)
    {
        _iconService = iconService;
        _webLogoService = webLogoService;
    }

    public async Task<HeaderViewModel> GetHeaderViewModel()
    {
        var webLogos = await _webLogoService.GetAllAsync();

        var icons = await _iconService.GetAllAsync();

        var headerViewModel = new HeaderViewModel
        {
          WebLogos = webLogos.ToList(),
          Icons = icons.ToList()

        };

        return headerViewModel;
    }
}

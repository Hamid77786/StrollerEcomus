using Microsoft.AspNetCore.Mvc;
using StrollerEcomus.BLL.Services.Contracts;

namespace StrollerEcomus.MVC.ViewComponents;

public class HeaderViewComponent:ViewComponent
{
    private readonly IHeaderService _headerService;

    public HeaderViewComponent(IHeaderService headerService)
    {
        _headerService = headerService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = await _headerService.GetHeaderViewModel();

        return View(model);
    }
}

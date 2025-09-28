

using StrollerEcomus.BLL.ViewModels;

namespace StrollerEcomus.BLL.Services.Contracts;

public interface IFooterService
{
    Task<FooterViewModel> GetFooterViewModel();

}

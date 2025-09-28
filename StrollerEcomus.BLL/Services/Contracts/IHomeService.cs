

using StrollerEcomus.BLL.ViewModels;

namespace StrollerEcomus.BLL.Services.Contracts;

public interface IHomeService
{
    Task<HomeViewModel> GetHomeViewModel();
}

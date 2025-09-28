

using StrollerEcomus.BLL.ViewModels;

namespace StrollerEcomus.BLL.Services.Contracts;

public interface IHeaderService
{
    Task<HeaderViewModel> GetHeaderViewModel();

}

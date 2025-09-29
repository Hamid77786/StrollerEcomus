using StrollerEcomus.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services.Contracts;

public interface IShopService
{
    Task<ShopViewModel> GetShopViewModel();
}

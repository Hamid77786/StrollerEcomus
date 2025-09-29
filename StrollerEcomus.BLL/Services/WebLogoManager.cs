using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services;

public  class WebLogoManager:CrudManager<WebLogo,WebLogoViewModel,CreateWebLogoViewModel,UpdateWebLogoViewModel>,IWebLogoService
{
    public WebLogoManager(IRepository<WebLogo> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}

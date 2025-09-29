using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class LogInContentManager : CrudManager<LogInContent, LogInContentViewModel, CreateLogInContentViewModel, UpdateLogInContentViewModel>, ILogInContentService
{
    public LogInContentManager(IRepository<LogInContent> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}

using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class LanguageManager : CrudManager<Language, LanguageViewModel, CreateLanguageViewModel, UpdateLanguageViewModel>, ILanguageService
{
    public LanguageManager(IRepository<Language> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}

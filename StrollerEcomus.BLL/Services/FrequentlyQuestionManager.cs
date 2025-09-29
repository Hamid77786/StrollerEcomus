using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class FrequentlyQuestionManager : CrudManager<FrequentlyQuestion, FrequentlyQuestionViewModel, CreateFrequentlyQuestionViewModel, UpdateFrequentlyQuestionViewModel>, IFrequentlyQuestionService
{
    public FrequentlyQuestionManager(IRepository<FrequentlyQuestion> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}

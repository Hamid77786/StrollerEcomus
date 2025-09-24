

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class FrequentlyQuestionRepository : EfCoreRepository<FrequentlyQuestion>, IFrequentlyQuestionRepository
{
    public FrequentlyQuestionRepository(AppDbContext context) : base(context)
    {

    }
}







using Data.Context;
using Entities;
using Entities.Intefaces;

namespace Data.Repositories;

public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(AppContextDB dbContext) : base(dbContext)
    {
    }
}
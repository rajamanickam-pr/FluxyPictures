using Fluxy.Data.EntityModels.Common;
using Fluxy.Repositories.Common;

namespace Fluxy.Repositories.Countries
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(long id);
    }
}

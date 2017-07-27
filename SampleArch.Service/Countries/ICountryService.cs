using Fluxy.Data.EntityModels.Common;
using Fluxy.Services.Common;

namespace Fluxy.Services.Countries
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(long Id);
    }
}

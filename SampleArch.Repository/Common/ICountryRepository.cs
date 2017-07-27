using Fluxy.Data.EntityModels.Common;

namespace SampleArch.Repository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(long id);
    }
}

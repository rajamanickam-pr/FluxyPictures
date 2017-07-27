using Fluxy.Data.EntityModels.Common;

namespace SampleArch.Service
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(long Id);
    }
}

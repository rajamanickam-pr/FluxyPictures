using System.Data.Entity;
using System.Linq;
using Fluxy.Data.EntityModels.Common;

namespace SampleArch.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
      public CountryRepository(DbContext context)
            : base(context)
        {
           
        }
        public Country GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();            
        }
    }
}

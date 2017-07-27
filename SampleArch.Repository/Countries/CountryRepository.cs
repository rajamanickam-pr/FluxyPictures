using System.Data.Entity;
using System.Linq;
using Fluxy.Data.EntityModels.Common;
using Fluxy.Repositories.Common;

namespace Fluxy.Repositories.Countries
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

using Fluxy.Data.EntityModels.Common;
using Fluxy.Services.Common;
using Fluxy.Repositories.Countries;
using Fluxy.Repositories.Common;

namespace Fluxy.Services.Countries
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;
        
        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }


        public Country GetById(long Id) {
            return _countryRepository.GetById(Id);
        }
    }
}

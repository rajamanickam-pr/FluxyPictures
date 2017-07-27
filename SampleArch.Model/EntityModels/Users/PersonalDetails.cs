using Fluxy.Data.EntityModels.Common;
using Fluxy.Data.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluxy.Data.EntityModels.Users
{
    public class PersonalDetails : Entity<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string ZipPostalCode { get; set; }

        public long CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}

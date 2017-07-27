using Fluxy.Data.EntityModels.Users;
using Fluxy.Data.Model.Common;
using System.Collections.Generic;

namespace Fluxy.Data.EntityModels.Common
{
    public class Country : AuditableEntity<long>
    {
        public string Name { get; set; }

        public virtual IEnumerable<PersonalDetails> PersonalDetails { get; set; }
    }
}

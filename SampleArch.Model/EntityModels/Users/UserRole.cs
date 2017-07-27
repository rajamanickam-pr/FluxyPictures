using Fluxy.Data.Model.Common;

namespace Fluxy.Data.EntityModels.Users
{
    public class UserRole : AuditableEntity<long>
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}

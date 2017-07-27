using Fluxy.Data.EntityModels.Users;
using Fluxy.Data.Model.Mapping;

namespace Fluxy.Data.Mapping.Users
{
    public class UserRoleMap : FluxyEntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole");
            this.HasKey(p => p.Id); 
            this.Property(ur => ur.Name).IsRequired();
        }
    }
}

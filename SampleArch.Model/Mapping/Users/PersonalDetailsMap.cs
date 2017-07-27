using Fluxy.Data.EntityModels.Users;

namespace Fluxy.Data.Model.Mapping.Users
{
    public partial class PersonalDetailsMap : FluxyEntityTypeConfiguration<PersonalDetails>
    {
        public PersonalDetailsMap()
        {
            this.ToTable("PersonalDetails");
            this.HasKey(p => p.Id);
        }
    }
}

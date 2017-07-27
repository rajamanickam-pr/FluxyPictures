using Fluxy.Data.EntityModels.Common;

namespace Fluxy.Data.Model.Mapping.Common
{
    public partial class CountryMap: FluxyEntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            this.ToTable("Country");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
        }
    }
}

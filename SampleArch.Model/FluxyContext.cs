using Fluxy.Data.Initilizers;
using Fluxy.Data.Model.Common;
using Fluxy.Data.Model.Mapping;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Fluxy.Data
{
    public class FluxyContext : DbContext
    {

        public FluxyContext()
            : base("Name=FluxyContext")
        {
            Database.SetInitializer(new FluxyDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(type => !String.IsNullOrEmpty(type.Namespace))
                      .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                          type.BaseType.GetGenericTypeDefinition() == typeof(FluxyEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;                   
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }    
}

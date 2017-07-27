using System.Data.Entity;
using Autofac;
using SampleArch.Repository;
using Fluxy.Data;

namespace SampleArch.Modules
{


    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(FluxyContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();         
        }
    }
}
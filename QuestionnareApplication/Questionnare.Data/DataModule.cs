using Autofac;
using Questionnare.Data.IRepository;
using Questionnare.Data.Repository;

namespace Questionnare.Data
{
    public class DataModule : Module
    {
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>));
            base.Load(builder);
        }
    }
}

using Autofac;
using Questionnare.Data;
using Questionnare.Services.IServices;
using Questionnare.Services.Services;

namespace Questionnare.Services
{
    public class ServiceModule : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DataModule>();
            builder.RegisterType<OccupationServices>().As<IOccupationServices>();
            builder.RegisterType<CountriesService>().As<ICountriesService>();
            builder.RegisterType<QuestionTypeServices>().As<IQuestionTypeServices>();
            builder.RegisterType<QuestionServices>().As<IQuestionServices>();

            base.Load(builder);
        }

    }
}

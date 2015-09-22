using Autofac;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using System;

namespace MeuSindico.Presentation.WebPresentation
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacModule());
            //TODO: See why this builder is acoplated method
            //builder.Populate(services);

            var container = builder.Build();

            return container.Resolve<IServiceProvider>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

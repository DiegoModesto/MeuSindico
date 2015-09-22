using Autofac;
using System;

namespace MeuSindico.Infrastructure.IoC.AutoFac
{
    public class AutofacServiceProvider : IServiceProvider
    {
        private readonly IComponentContext _componentContext;

        public AutofacServiceProvider(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public object GetService(Type serviceType)
        {
            return _componentContext.ResolveOptional(serviceType);
        }
    }
}

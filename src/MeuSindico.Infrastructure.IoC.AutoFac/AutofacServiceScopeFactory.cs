using Autofac;
using Microsoft.Framework.DependencyInjection;

namespace MeuSindico.Infrastructure.IoC.AutoFac
{
    public class AutofacServiceScopeFactory : IServiceScopeFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacServiceScopeFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public IServiceScope CreateScope()
        {
            return new AutofacServiceScope(_lifetimeScope.BeginLifetimeScope());
        }
    }
}

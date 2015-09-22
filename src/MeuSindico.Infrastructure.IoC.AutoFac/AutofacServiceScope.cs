using System;
using Microsoft.Framework.DependencyInjection;
using Autofac;

namespace MeuSindico.Infrastructure.IoC.AutoFac
{
    public class AutofacServiceScope : IServiceScope
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacServiceScope(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            ServiceProvider = _lifetimeScope.Resolve<IServiceProvider>();
        }

        public IServiceProvider ServiceProvider { get; }

        public void Dispose()
        {
            _lifetimeScope.Dispose();
        }
    }
}

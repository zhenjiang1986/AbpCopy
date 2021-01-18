using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Reflection;

namespace Volo.Abp.DependencyInjection
{
    public abstract class ConventionalRegistrarBase : IConventionalRegistrar
    {
        public virtual void AddAssembly(IServiceCollection services, Assembly assembly)
        {

        }

        public virtual void AddTypes(IServiceCollection services, params Type[] types)
        {

        }

        public abstract void AddType(IServiceCollection services, Type type);

        protected virtual bool IsConventionalRegistrationDisabled(Type type)
        {
            return false;
        }

        protected virtual void TriggerServiceExposing(IServiceCollection services, Type implementationType, List<Type> serviceTypes)
        {

        }
    }
}
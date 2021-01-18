using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.DependencyInjection
{
    public class ServiceRegistrationActionList : List<Action<IOnServiceRegistredContext>>
    {

    }
}

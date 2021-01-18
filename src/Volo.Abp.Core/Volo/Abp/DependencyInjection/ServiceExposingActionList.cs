using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.DependencyInjection
{
    public class ServiceExposingActionList : List<Action<IOnServiceExposingContext>>
    {
    }
}

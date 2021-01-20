using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Aspects
{
    public interface IAvoidDuplicateCrossCuttingConcerns
    {

        List<string> AppliedCrossCuttingConcerns { get; }

    }
}

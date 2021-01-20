using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Content
{
    public interface IRemoteStreamContent
    {
        string ContentType { get; }

        long? ContentLength { get; }

        Stream GetStream();
    }
}

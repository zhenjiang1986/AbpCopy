using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Bundling
{
    public class BundleDefinition
    {

        public string Source { get; set; }


        public Dictionary<string,string> AdditionalProperties { get; set; }


        public bool ExcludeFromBundle { get; set; }

        public BundleDefinition()
        {
            AdditionalProperties = new Dictionary<string, string>();
        }

    }
}

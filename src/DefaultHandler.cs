using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ParseTo
{
    internal sealed class DefaultParseToHandler : Handler
    {
        protected override IEnumerable<Assembly> LoadExtensibleAssemblies()
        {
            return Enumerable.Empty<Assembly>();
        }
    }
}

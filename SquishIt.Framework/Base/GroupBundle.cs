using System.Collections.Generic;
using SquishIt.Framework.Utilities;
using SquishIt.Framework.Minifiers;

namespace SquishIt.Framework.Base
{
    internal class GroupBundle
    {
        internal LinkedHashSet<Asset> Assets;
        internal Dictionary<string, string> Attributes;
        internal int Order { get; set; }

        internal GroupBundle()
            : this(new Dictionary<string, string>())
        {
        }

        internal GroupBundle(Dictionary<string, string> attributes)
        {
            EqualityComparer<Asset> assetEqualityComparer = new Asset.EqualityComparer();
            Assets = new LinkedHashSet<Asset>(assetEqualityComparer);
            Attributes = attributes;
        }
    }
}
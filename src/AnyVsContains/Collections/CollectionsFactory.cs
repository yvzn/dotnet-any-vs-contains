using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyVsContains.Collections
{
    public class CollectionsFactory
    {
        public static ICollection<T> Create<T>(TypeOfCollection type, IEnumerable<T> dataset) =>
            type switch
            {
                TypeOfCollection.Array => dataset.ToArray(),
                TypeOfCollection.List => dataset.ToList(),
                TypeOfCollection.HashSet => new HashSet<T>(dataset),
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            };
    }
}

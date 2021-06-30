using System.Collections;

namespace AnyVsContains.Dataset
{
    public interface IGenerator
    {
        // non-generic interface for dataset generators, exposed mainly for testing

        IEnumerable GetDataset(int count);

        object GetSearchPositive();
    }
}

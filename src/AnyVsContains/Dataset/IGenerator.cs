using System.Collections;
using System.Collections.Generic;

namespace AnyVsContains.Dataset
{
    public interface IGenerator<T>
    {
        IEnumerable<T> GetDataset(int count);

        T GetSearchPositive();
    }

    public interface IGenerator
    {
        IEnumerable GetDataset(int count);

        object GetSearchPositive();
    }
}

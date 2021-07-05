using System;

namespace AnyVsContains.Dataset
{
    public class GeneratorOfRecords : Generator<Contract>
    {
        public override Contract GetSearchPositive()
        {
            return new Contract("needle", "propA", "propB", -1);
        }

        private protected override Contract GetSearchNegative(int index)
        {
            return new Contract(random.Next().ToString("x"), random.Next().ToString("x"), random.Next().ToString("x"), random.Next());
        }
    }

    public class Contract : IEquatable<Contract>
    {
        readonly string reference;
        readonly string propertyA;
        readonly string propertyB;
        readonly int propertyC;

        public Contract(string reference, string propertyA, string propertyB, int propertyC)
        {
            this.reference = reference;
            this.propertyA = propertyA;
            this.propertyB = propertyB;
            this.propertyC = propertyC;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Contract);
        }

        public bool Equals(Contract other)
        {
            return other != null &&
                   reference == other.reference &&
                   propertyA == other.propertyA &&
                   propertyB == other.propertyB &&
                   propertyC == other.propertyC;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(reference, propertyA, propertyB, propertyC);
        }
    }
}

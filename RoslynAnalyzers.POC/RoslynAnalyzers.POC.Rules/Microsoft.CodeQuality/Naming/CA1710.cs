using System;
using System.Collections;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Naming
{
    /// <summary>
    /// Rule ID: CA1710 (Identifiers should have correct suffix)
    /// </summary>
    public class CA1710
    {
    }

    public class SomeClassWithoutCorrectSuffix: ICollection
    {
        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1829" (Use Length/Count property instead of Enumerable.Count method)
    /// </summary>
    public class CA1829
    {
        public void TestCountViolation()
        {
            var c = new EnumerableCountViolation();
        }

        public class EnumerableCountViolation
        {
            public int GetCount(int[] array)
                => array.Count();

            public int GetCount(ICollection<int> collection)
                => collection.Count();

            public int GetFixedCount(int[] array)
               => array.Length;

            public int GetFixedCount(ICollection<int> collection)
                => collection.Count;
        }
    }
}

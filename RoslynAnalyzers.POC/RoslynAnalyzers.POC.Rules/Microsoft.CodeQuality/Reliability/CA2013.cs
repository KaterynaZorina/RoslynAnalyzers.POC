using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Reliability
{
    /// <summary>
    /// Rule ID: "CA2013" (Do not use ReferenceEquals with value types)
    /// </summary>
    public class CA2013
    {
        public void TestReferenceEqualsWithValueType()
        {
            int int1 = 1, int2 = 1;

            // Violation occurs, returns false.
            Console.WriteLine(Object.ReferenceEquals(int1, int2));  // false

            // Use appropriate equality operator or method instead
            Console.WriteLine(int1 == int2);                        // true
            Console.WriteLine(Object.Equals(int1, int2));           // true
        }
    }
}

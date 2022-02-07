using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1825" (Avoid zero-length array allocations)
    /// </summary>
    public class CA1825
    {
        public void TestZeroLengthArray()
        {
            var violation = new ZeroLengthArrayViolation();
            violation.M1();
        }

    }

    public class ZeroLengthArrayViolation
    {
        public void M1()
        {
            // Violates rule CA1825.
            var violation = new int[0];

            // Resolves rule CA1825 violation.
            var fix = Array.Empty<int>();
        }
    }
}

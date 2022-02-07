using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Usage
{
    /// <summary>
    /// Rule ID: "2208" (Instantiate argument exceptions correctly)
    /// </summary>
    public class CA2208
    {
        public void Violation(string test)
        {
            if (string.IsNullOrEmpty(test))
            {
                throw new ArgumentException(nameof(test), "something wrong");

                throw new ArgumentException("something wrong", nameof(test));
            }
        }
    }
}

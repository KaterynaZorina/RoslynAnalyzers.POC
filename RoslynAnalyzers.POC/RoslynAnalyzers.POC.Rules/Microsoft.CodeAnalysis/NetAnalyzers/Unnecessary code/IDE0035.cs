using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Remove unreachable code (IDE0035)
    /// </summary>
    public class IDE0035
    {
        public void Test()
        {
            throw new InvalidOperationException();
            // TODO: check why is no error here
            var i = 10;
        }
    }
}

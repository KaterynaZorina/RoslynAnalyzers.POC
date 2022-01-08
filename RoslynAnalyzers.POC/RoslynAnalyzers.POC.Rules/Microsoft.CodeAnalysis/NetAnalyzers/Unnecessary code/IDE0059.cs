using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Remove unnecessary value assignment (IDE0059)
    /// </summary>
    public class IDE0059
    {
        public void Test()
        {
            var unused = Convert.ToInt32("35");
        }
    }
}

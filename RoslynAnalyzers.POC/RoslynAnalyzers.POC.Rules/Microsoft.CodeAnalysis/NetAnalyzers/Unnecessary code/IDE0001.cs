using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Simplify name (IDE0001)
    /// </summary>
    public class IDE0001
    {
        public void Test()
        {
            var result = new System.Text.StringBuilder();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Remove unnecessary cast (IDE0004)
    /// </summary>
    public class IDE0004
    {
        public void Test()
        {
            int v = (int)0;
        }
    }
}

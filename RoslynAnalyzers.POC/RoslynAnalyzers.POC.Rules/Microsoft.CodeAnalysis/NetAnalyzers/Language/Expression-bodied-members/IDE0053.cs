using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_bodied_members
{
    /// <summary>
    /// Use expression body for lambdas (IDE0053)
    /// </summary>
    public class IDE0053
    {
        public void Test()
        {
            Func<int, int> square = x => { return x * x; };
        }
    }
}

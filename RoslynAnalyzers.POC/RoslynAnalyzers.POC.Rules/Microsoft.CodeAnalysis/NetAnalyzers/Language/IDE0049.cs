using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language
{
    /// <summary>
    /// Use language keywords instead of framework type names for type references (IDE0049)
    /// </summary>
    public class IDE0049
    {
        Int32 number = 123;
    }
}

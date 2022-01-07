using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Simplify 'default' expression (IDE0034)
    /// </summary>
    public class IDE0034
    {
        private readonly int _number = default(int);
    }
}

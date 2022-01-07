using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_bodied_members
{
    /// <summary>
    /// Use expression body for properties (IDE0025)
    /// </summary>
    public class IDE0025
    {
        public int Number { get { return 20; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Use auto property (IDE0032)
    /// </summary>
    public class IDE0032
    {
        private readonly int _age;

        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}

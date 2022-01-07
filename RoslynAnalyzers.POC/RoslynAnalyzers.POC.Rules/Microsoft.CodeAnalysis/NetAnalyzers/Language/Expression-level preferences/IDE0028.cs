using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Use collection initializers (IDE0028)
    /// </summary>
    public class IDE0028
    {
        public void Test()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
        }
    }
}

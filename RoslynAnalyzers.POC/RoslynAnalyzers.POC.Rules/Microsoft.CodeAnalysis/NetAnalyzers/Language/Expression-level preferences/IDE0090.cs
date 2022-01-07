using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    public class Vegetable
    {
        public string Name { get; set; }
    }

    public class IDE0090
    {
        public void Test()
        {
            var vegetable = new Vegetable() { Name = "Broccoli" };
        }
    }
}

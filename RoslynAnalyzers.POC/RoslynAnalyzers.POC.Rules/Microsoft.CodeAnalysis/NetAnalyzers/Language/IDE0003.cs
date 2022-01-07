using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language
{
    /// <summary>
    /// this and Me preferences (IDE0003 and IDE0009)
    /// </summary>
    public class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            this.Name = "123";
        }
    }

    public class IDE0003
    {
    }
}

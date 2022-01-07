using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class IDE0017
    {
        public void Test()
        {
            var person = new Person();
            person.Name = "Test name";
        }
    }
}

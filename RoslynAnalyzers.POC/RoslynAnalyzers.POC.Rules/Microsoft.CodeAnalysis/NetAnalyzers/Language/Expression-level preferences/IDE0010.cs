using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    public enum Fruit
    {
        Apple,
        Mango,
        Durian
    }

    /// <summary>
    /// Add missing cases to switch statement (IDE0010)
    /// </summary>
    public class IDE0010
    {
        public void TestMethod()
        {
            var fruitType = Fruit.Apple;

            switch (fruitType)
            {
                case Fruit.Apple:
                    Console.WriteLine("You have got an apple");
                    break;
            }
        }
    }
}

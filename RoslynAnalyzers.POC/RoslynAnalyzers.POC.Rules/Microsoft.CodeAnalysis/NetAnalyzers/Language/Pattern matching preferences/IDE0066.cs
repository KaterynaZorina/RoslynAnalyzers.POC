using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Pattern_matching_preferences
{
    public enum Vehicle
    {
        Car,
        Motorcycle,
        Bicycle
    }

    /// <summary>
    /// Use switch expression (IDE0066)
    /// </summary>
    public class IDE0066
    {
        public string Test()
        {
            var vehicleType = Vehicle.Bicycle;

            var resultStr = string.Empty;

            switch (vehicleType)
            {
                case Vehicle.Car:
                    resultStr = "Car";
                    break;
                case Vehicle.Motorcycle:
                    resultStr = "Motorcycle";
                    break;
                case Vehicle.Bicycle:
                    resultStr = "Bicycle";
                    break;
                default:
                    resultStr = string.Empty;
                    break;
            }

            return resultStr;
        }
    }
}

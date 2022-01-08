namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Remove unnecessary equality operator (IDE0100)
    /// </summary>
    public class IDE0100
    {
        public void Test()
        {
            var isValid = true;

            if (isValid == true)
            {

            }
        }
    }
}

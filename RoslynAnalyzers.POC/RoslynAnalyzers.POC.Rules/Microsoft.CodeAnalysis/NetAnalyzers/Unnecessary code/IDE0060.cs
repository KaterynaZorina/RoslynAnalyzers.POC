namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Unnecessary_code
{
    /// <summary>
    /// Remove unused parameter (IDE0060)
    /// </summary>
    public class IDE0060
    {
        private int Calculate(int a, int b)
        {
            return a;
        }
    }
}

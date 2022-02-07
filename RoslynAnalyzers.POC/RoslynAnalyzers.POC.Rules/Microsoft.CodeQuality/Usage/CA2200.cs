using System;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Usage
{
    /// <summary>
    /// Rule ID: "CA2200" (Rethrow to preserve stack details)
    /// </summary>
    public class CA2200
    {
        public void Test()
        {
            var s = new RethrowViolation();

            s.CatchException();
        }
    }

    public class RethrowViolation
    {
        public static void Main2200()
        {
            var testRethrow = new RethrowViolation();
            testRethrow.CatchException();
        }

        public void CatchException()
        {
            try
            {
                CatchAndRethrowExplicitly();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Explicitly specified:{0}{1}",
                   Environment.NewLine, e.StackTrace);
            }

            try
            {
                CatchAndRethrowImplicitly();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("{0}Implicitly specified:{0}{1}",
                   Environment.NewLine, e.StackTrace);
            }
        }

        public void CatchAndRethrowExplicitly()
        {
            try
            {
                ThrowException();
            }
            catch (ArithmeticException e)
            {
                // Violates the rule.
                throw e;
            }
        }

        public void CatchAndRethrowImplicitly()
        {
            try
            {
                ThrowException();
            }
            catch (ArithmeticException)
            {
                // Satisfies the rule.
                throw;
            }
        }

        public void ThrowException()
        {
            throw new ArithmeticException("illegal expression");
        }
    }
}

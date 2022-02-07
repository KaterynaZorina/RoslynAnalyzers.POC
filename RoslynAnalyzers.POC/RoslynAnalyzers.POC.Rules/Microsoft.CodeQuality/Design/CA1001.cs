using System;
using System.IO;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Design
{
    /// <summary>
    /// Rule ID: "CA1001" (Types that own disposable fields should be disposable)
    /// </summary>
    public class CA1001
    {
        public void TestNoDisposeMethod()
        {
            var noDsipose = new NoDisposeMethod();
        }
    }

    // This class violates the rule.
    public class NoDisposeMethod
    {
        private readonly FileStream _newFile;

        public NoDisposeMethod()
        {
            _newFile = new FileStream(@"c:\temp.txt", FileMode.Open);
        }
    }

    // This class satisfies the rule.
    public class HasDisposeMethod: IDisposable
    {
        private readonly FileStream _newFile;

        public HasDisposeMethod()
        {
            _newFile = new FileStream(@"c:\temp.txt", FileMode.Open);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources.
                _newFile.Close();
            }
            // Free native resources.
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

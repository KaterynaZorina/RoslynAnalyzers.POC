namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1806" (Do not ignore method results)
    /// </summary>
    public class CA1806
    {
        public void TestBookViolation1()
        {
            var book = new BookViolation1("test");
        }

        public void TestBookViolation2()
        {
            var book = new BookViolation2();
        }
    }

    //Rule violation
    public class BookViolation1
    {
        private readonly string _title;

        public BookViolation1(string title)
        {
            if (title != null)
            {
                // Violates this rule
                title.Trim();
            }

            _title = title;
        }

        public string Title
        {
            get { return _title; }
        }
    }

    //Rule violation
    public class BookViolation2
    {
        public BookViolation2()
        {
        }

        public static BookViolation2 CreateBook()
        {
            // Violates this rule
            new BookViolation2();
            return new BookViolation2();
        }
    }
}

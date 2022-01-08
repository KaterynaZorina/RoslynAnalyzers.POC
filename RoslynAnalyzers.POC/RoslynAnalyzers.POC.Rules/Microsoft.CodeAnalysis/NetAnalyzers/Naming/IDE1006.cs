namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Naming
{
    /// <summary>
    /// Code Rule ID: IDE1006 (Naming rule violation)
    /// </summary>
    public class IDE1006
    {
        // dotnet_naming_rule.non_private_static_fields_should_be_pascal_case.severity = error
        // dotnet_naming_symbols.non_private_static_fields.applicable_accessibilities = public, protected, internal, protected internal, private protected
        // dotnet_naming_style.non_private_static_field_style.capitalization = pascal_case
        public static int someStaticField = 15;
        protected static int someStaticFieldA = 15;
        internal static int someStaticFieldB = 15;
        protected internal static int someStaticFieldC = 15;
        private protected static int someStaticFieldD = 15;

        // dotnet_naming_rule.constants_should_be_pascal_case.severity = error
        public const string constStrA = "smth";
        private const string constStrB = "smth";

        // dotnet_naming_rule.public_fields_should_be_pascal_case.severity = warning
        public int somePublicField = 16;

        // dotnet_naming_rule.static_fields_should_be_camel_case.severity = error
        private static int NumA = 30;

        // dotnet_naming_rule.camel_case_for_private_internal_fields.severity = error
        private readonly string internalStr;

        // dotnet_naming_rule.locals_should_be_camel_case.severity = error
        private void Calc(int NumParam)
        {
            var Str = "string";

            // dotnet_naming_rule.local_functions_should_be_pascal_case.severity = error
            string concat()
            {
                return string.Empty;
            }
        }

        // dotnet_naming_rule.type_parameter_naming.severity = warning
        private S GenericFunc<S>() where S : new()
        {
            return new S();
        }
    }

    public class ClassA
    {
        // dotnet_naming_rule.members_should_be_pascal_case.severity = warning
        public string propA { get; set; }
    }
}

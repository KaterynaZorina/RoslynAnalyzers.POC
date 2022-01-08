using System;
using System.Collections.Generic;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Formatting
{
    /// <summary>
    /// Rule ID: "IDE0055" (Fix formatting)
    /// </summary>
    public class IDE0055
    {
        public void TestFormattingRules()
        {
            // dotnet_sort_system_directives_first = true
            // dotnet_separate_import_directive_groups = false

            // New line preferences

            // csharp_new_line_before_open_brace = all
            var isValid = true;
            if (isValid)
            {

            }

            // csharp_new_line_before_else = false
            if (isValid)
            {

            } else
            {
            }

            // csharp_new_line_before_catch = true
            try
            {
            }
            catch (Exception e)
            {
            }

            // csharp_new_line_before_finally = true
            try
            {
            }
            finally
            {
            }

            // csharp_new_line_before_members_in_object_initializers = true
            var testObj = new TestClass
            {
                A = "Test",
                B = "New test"
            };

            // csharp_new_line_before_members_in_anonymous_types = true
            var obj = new
            {
                A = "Test",
                B = "New test"
            };

            // Indentation preferences

            // csharp_indent_case_contents = true
            var animal = Animal.Alien;

            switch (animal)
            {
                case Animal.Alien:
                    Console.WriteLine("You have got an alien as a pet! Congrats!");
                    break;
            }

            // csharp_indent_switch_labels = true
            switch (animal)
            {
                case Animal.Cat:
                    Console.WriteLine("You have got a cat");
                    break;
            }

            // csharp_indent_labels = one_less_than_current
            if (isValid)
            {
                goto error;
            }
        error:
            throw new Exception();

            // csharp_indent_block_contents = true
            if (isValid)
            {
            Console.WriteLine("Boo!");
            }

            // csharp_indent_braces = false
            if (isValid)
                {
                Console.WriteLine("Boo!");
                }

            // csharp_indent_case_contents_when_block = false
            switch (animal)
                {
                case Animal.Alien:
                    Console.WriteLine("You have got an alien as a pet! Congrats!");
                    break;
                }

            // Space preferences

            // csharp_space_after_cast = true
            long a = 10;
            var b = (int)a;

            // csharp_space_after_keywords_in_control_flow_statements = true
            if(isValid)
            {

            }

            // csharp_space_between_parentheses = false
            var num = ( 1 + 10 );

            // csharp_space_around_binary_operators = before_and_after
            var num2 = (1+10);

            // csharp_space_between_method_declaration_parameter_list_parentheses = false
            void InternalTestMethod( int a ) { }

            // csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
            void InternalMethod( ) { }

            // csharp_space_between_method_declaration_name_and_open_parenthesis = false
            void AnotherInternalMethod () { }

            // csharp_space_between_method_call_parameter_list_parentheses = false
            InternalTestMethod( 10 );

            // csharp_space_between_method_call_empty_parameter_list_parentheses = false
            AnotherInternalMethod( );

            // csharp_space_between_method_call_name_and_opening_parenthesis = false
            AnotherInternalMethod ();

            // csharp_space_after_comma = true
            var list = new List<int> { 1,2,3 };

            // csharp_space_before_comma = false
            var listA = new List<int> { 1 , 2 };

            // csharp_space_after_dot = false
            var name = testObj. A;

            // csharp_space_before_dot = false
            var anotherName = testObj .B;

            // csharp_space_after_semicolon_in_for_statement = true
            for (var i = 0;i < 2;i++) { }

            // csharp_space_before_semicolon_in_for_statement = false
            for (var i = 0 ; i < 2; i++) { }

            // csharp_space_around_declaration_statements = false
            var x  =  0;

            // csharp_space_before_open_square_brackets = false
            var numbers = new int [] { 1, 2, 3, 4, 5 };

            // csharp_space_between_empty_square_brackets = false
            numbers = new int[ ] { 1, 2, 3, 4, 5 };

            // csharp_space_between_square_brackets = false
            numbers = new int[ 5 ];

            // Wrap options

            // csharp_preserve_single_line_statements = false
            int i = 0; string personName = "Bob";
        }

        // csharp_preserve_single_line_blocks = true
        // TODO: check why an error is not shown
        public int NumberProp
        {
            get; set;
        }
    }

    public class TestClass
    {
        public string A { get; set; }
        public string B { get; set; }
    }

    public enum Animal
    {
        Dog,
        Cat,
        Alien
    }

    public abstract class Parent { }

    // csharp_space_before_colon_in_inheritance_clause = false
    public class Child : Parent { }

    // csharp_space_after_colon_in_inheritance_clause = true
    public class AnotherChild:Parent { }
}

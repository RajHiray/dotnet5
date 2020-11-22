using System;
using System.Globalization;

/*
 * Benefits of Records:
       - Simple to set up.
       - Thread-safe
       - Easy/safe to share with functions.

 * When to Use Records:
       - Capturing external data that doesn't change.
       - API calls.                 
       - Read-only data.

 * When not to use Records:
       - When you need to change the data (Entity Framework).
*/
namespace CSharpRecords
{
    class Program
    {
        static void Main(string[] args)
        {

            Record1 r1a = new("John", "Smith");
            Record1 r1b = new("John", "Smith");
            Record1 r1c = new("Robert", "Smith");

            Class1 c1a = new("John", "Smith");
            Class1 c1b = new("John", "Smith");
            Class1 c1c = new("Robert", "Smith");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String: { r1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(r1a, r1b) }");
            Console.WriteLine($"Are the two objects reference equal: { ReferenceEquals(r1a, r1b) }");
            Console.WriteLine($"Are the two objects ==: { r1a == r1b }");
            Console.WriteLine($"Hash code of object A: { r1a.GetHashCode() }");
            Console.WriteLine($"Hash code of object B: { r1b.GetHashCode() }");
            Console.WriteLine($"Hash code of object C: { r1c.GetHashCode() }");

            Console.WriteLine("\n********************************\n");

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: { c1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(c1a, c1b) }");
            Console.WriteLine($"Are the two objects reference equal: { ReferenceEquals(c1a, c1b) }");
            Console.WriteLine($"Are the two objects ==: { c1a == c1b }");
            Console.WriteLine($"Hash code of object A: { c1a.GetHashCode() }");
            Console.WriteLine($"Hash code of object B: { c1b.GetHashCode() }");
            Console.WriteLine($"Hash code of object C: { c1c.GetHashCode() }");

            Console.WriteLine("\n********************************\n");

            //Records has Deconstruct which can map its values to ValueTuple.
            var (fn, ln) = r1a;
            Console.WriteLine($"The value of fn is { fn } and the value of ln is { ln }");

            // Copy records props with manipulation for some props.
            Record1 r1d = r1a with
            {
                FirstName = "Jon"
            };
            Console.WriteLine($"Jon's record: { r1d }");

            Console.WriteLine("\n********************************\n");

            // Records with inheritance.
            User1 u1a = new(1,"David", "Williams");
            Console.WriteLine($"To String: { u1a }");

            Console.WriteLine("\n********************************\n");

            // Records with custome implementation of props and fumctions.
            Record2 r2a = new("JoHn", "smiTh");
            Console.WriteLine($"R2a Value: { r2a }");
            Console.WriteLine($"R2a fn: { r2a.FirstName }  ln: { r2a.LastName }");
            Console.WriteLine(r2a.SayHello());
        }
    }

    // Records is Immutable - The values cannot be changes.
    public record Record1(string FirstName, string LastName);

    //Record inherited from record only.
    public record User1(int Id, string FirstName, string LastName) : Record1(FirstName, LastName);

    //records can have functions and props with custome implementation.
    public record Record2(string FirstName, string LastName)
    {
        private string _firstName = FirstName;
        private string _lastName = LastName;
        static TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public string FirstName
        {
            get { return ti.ToTitleCase(_firstName); }
            init { }
        }

        public string LastName
        {
            get { return ti.ToTitleCase(_lastName); }
            init { }
        }

        public string FullName { get => $"{ FirstName } { LastName }"; }

        public string SayHello()
        {
            return $"Hello { FullName }";
        }
    }
}

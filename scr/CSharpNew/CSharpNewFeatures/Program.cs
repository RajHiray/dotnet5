using System;
using CSharpNewFeatures;

/// <summary> 1
/// New start point without main method.
/// Direct access for args.
/// Direct access for static/Non static function within file.
/// </summary>
Console.WriteLine("Hello .NET 5 with C#- 9 !");
Console.WriteLine($"Number of agrs pass : {args.Length}");
Console.WriteLine($"Call Static Function (3+4): {Add(3,4)}");
Console.WriteLine($"Call Member Function (7-4): {Sub(7, 4)}");

// 2.No need to specifiying datatype after new operator.
PersonModel user0 = new();
// Earlier way.
PersonModel user00 = new PersonModel();

// 3. init accessor that is a variant of the set accessor which can only be called during object initialization.
PersonModel user1 = new(1, "Jonny", "Smith");
PersonModel user2 = new() { Id = 2, FisrtName = "Robert", LastName = "Smith" };
PersonModel user3 = null;

/// Error if not commented : can not assigned new value. Id is init prop.
//user1.Id = 3;
user1.FisrtName = "John";

// not is going to be convenient in if-conditions containing is-expressions.
if (user1 is not null)
    Console.WriteLine($"Hello {user1.FisrtName} {user1.LastName} {user1.Id}");

if (user2 is not null)
    Console.WriteLine($"Hello {user2.FisrtName} {user2.LastName} {user2.Id}");

if(user3 is null)
    Console.WriteLine("The value of user3 is not yet set");

/// <summary>
/// Member function to Add x and y.
/// </summary>
double Add(double x, double y)
{
    return x + y;
}

/// <summary>
/// Static function to Substarct value y from x.
/// </summary>
static double Sub(double x, double y)
{
    return x - y;
}
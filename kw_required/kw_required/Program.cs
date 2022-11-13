var person1 = new Person { Name = "Alice" };
var person2 = new Person { Name = "Alice", Orgtanization = "Company" };
// ↓できない
//var person3 = new Person { Orgtanization = "Company" };
// ↓できない
//var person4 = new Person();
sub(person1);
sub(person2);

static void sub(Person p) => Console.WriteLine($"{p.Name} in {p.Orgtanization ?? "unknown organization"}");

public class Person
{
    public required string Name { get; init; }
    public string? Orgtanization { get; init; }
}



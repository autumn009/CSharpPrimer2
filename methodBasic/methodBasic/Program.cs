hello();
helloTo("Joe");
helloTo("Mike");
Console.WriteLine(calcAdd(1,2));
helloShortForm();
helloToShortForm("Joe");
helloToShortForm("Mike");
Console.WriteLine(calcAddShortForm(1, 2));

void hello()
{
    Console.WriteLine("Hello!");
}

void helloTo(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

int calcAdd(int x, int y)
{
    return x + y;
}

void helloShortForm() => Console.WriteLine("Hello!");
void helloToShortForm(string name) => Console.WriteLine($"Hello, {name}!");
int calcAddShortForm(int x, int y) => x + y;

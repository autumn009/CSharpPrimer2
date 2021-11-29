// メソッド呼び出し
hello();
helloTo("Joe");
helloTo("Mike");
Console.WriteLine(calcAdd(1,2));
helloShortForm();
helloToShortForm("Joe");
helloToShortForm("Mike");
Console.WriteLine(calcAddShortForm(1, 2));

// メソッド宣言 (通常表記)
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

// メソッド宣言(短縮表記)
void helloShortForm() => Console.WriteLine("Hello!");
void helloToShortForm(string name) => Console.WriteLine($"Hello, {name}!");
int calcAddShortForm(int x, int y) => x + y;

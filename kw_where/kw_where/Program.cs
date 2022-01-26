Console.WriteLine("class MyClass<T>");
var x1 = new MyClass<int>();
x1.Sub(123);
var x2 = new MyClass<string>();
x2.Sub("Hello!");
Console.WriteLine("class MyClass2<T> where T : IEnumerable<int>");
var x3 = new MyClass2<int[]>();
x3.Sub(new int[] { 1, 2, 3 });
var x4 = new MyClass2<List<int>>();
x4.Sub(new List<int>() { 1, 2, 3 });
Console.WriteLine("class MyClass3<T> where T : new()");
var x5 = new MyClass3<MyDummy>();
x5.Sub();

// new 可能なダミーのクラス
class MyDummy
{
}

class MyClass<T>
{
    public void Sub(T parameter)
    {
        Console.WriteLine(parameter?.ToString());
    }
}

class MyClass2<T> where T : IEnumerable<int>
{
    public void Sub(T parameter)
    {
        foreach (var item in parameter) Console.WriteLine($"member={item}");
    }
}

class MyClass3<T> where T : new()
{
    public void Sub()
    {
        var x = new T();
        Console.WriteLine(x.ToString());
    }
}

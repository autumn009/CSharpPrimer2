Action<string, int> a = (x,y) =>
{
    Console.WriteLine($"ラムダ式1");
    Console.WriteLine($"x={x}");
    Console.WriteLine($"y={y}");
};

Action<string> b = x =>
{
    Console.WriteLine($"ラムダ式2");
    Console.WriteLine($"x={x}");
};

Action c = () => Console.WriteLine($"ラムダ式3");

Func<int, int, int> d = (x, y) =>
  {
      Console.WriteLine($"ラムダ式4");
      Console.WriteLine($"x={x}");
      Console.WriteLine($"y={y}");
      return x + y;
  };

Action<string, int> e = delegate(string x, int y)
{
    Console.WriteLine($"匿名メソッド");
    Console.WriteLine($"x={x}");
    Console.WriteLine($"y={y}");
};

a("Hello1", 1234);
b("Hello2");
c();
Console.WriteLine($"d(12, 34)={d(12, 34)}");
e("Hello3", 1234);

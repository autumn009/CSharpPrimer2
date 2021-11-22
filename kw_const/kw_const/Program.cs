const int a = 123;
const int b = 456;
const int c = a + b;    // OK
//const int d = Math.Max(a, b);   // NG
int d = Math.Max(a, b);    // OK
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"c={c}");
Console.WriteLine($"{a}と{b}の最大値は{d}");

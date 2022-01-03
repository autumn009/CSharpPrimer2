int a0 = 1;
int b0 = 2;
int d0 = 4;
int e0 = 5;
int e1 = 6;
int e2 = 7;

Console.WriteLine($"a0={a0}");
Console.WriteLine($"b0={b0}");
Console.WriteLine($"d0={d0}");
Console.WriteLine($"e0={e0}");
Console.WriteLine($"e1={e1}");
Console.WriteLine($"e2={e2}");

sub(a0, in b0, out int c0, ref d0, e0, e1, e2);

Console.WriteLine($"a0={a0}");
Console.WriteLine($"b0={b0}");
Console.WriteLine($"c0={c0}");
Console.WriteLine($"d0={d0}");

void sub(int a, in int b, out int c, ref int d, params int[] e)
{
    Console.WriteLine("sub called");
    a = a + 1;
    Console.WriteLine($"b={b}");
    // 以下の行は許されない。bには書き込めない
    //b = b + 1;
    // 以下の行は許されない。cは読み出せない
    //c = c + 1;
    c = 999;
    d = d + 1;
    foreach (var item in e) Console.WriteLine($"item={item}");
    Console.WriteLine("sub done");
}

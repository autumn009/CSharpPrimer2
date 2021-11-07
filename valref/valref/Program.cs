// 参照型の場合
Console.WriteLine("参照型の場合");
T1 t1 = new T1();
t1.A = 123;
T1 copy1 = t1;
t1.A = 456;
Console.WriteLine($"t1.A={t1.A} copy1.A={copy1.A}");
// 値型の場合
Console.WriteLine("値型の場合");
T2 t2 = new T2();
t2.A = 123;
T2 copy2 = t2;
t2.A = 456;
Console.WriteLine($"t2.A={t2.A} copy2.A={copy2.A}");
// 参照型の型の宣言
class T1
{
    internal int A { get; set; }
}
// 値型の型の宣言
struct T2
{
    internal int A { get; set; }
}


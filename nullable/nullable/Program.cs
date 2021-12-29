Console.WriteLine("ボックス化とボックス化解除");
int a = 123;
// ボックス化
object o = a;
// ボックス化解除
int b = (int)o;
Console.WriteLine($"b={b}");

Console.WriteLine("null 許容値型");
int? c = 123;
c = null;
c = 456;
Console.WriteLine($"c={c}");

Console.WriteLine("null 許容参照型");
string? s = "the Jedi";
s = null;
s = "Return of the Jedi";
Console.WriteLine($"s={s}");

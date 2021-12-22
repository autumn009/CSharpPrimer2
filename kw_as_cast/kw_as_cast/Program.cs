Console.WriteLine("キャストの利用例"); 
byte a=1;
byte b=2;
byte c = (byte)(a + b);
Console.WriteLine($"a+b={c}");

Console.WriteLine("as演算子の利用例");
object s = "hello!";
string? t = s as string;
if (t != null) Console.WriteLine($"upper letter of s={t.ToUpper()}");

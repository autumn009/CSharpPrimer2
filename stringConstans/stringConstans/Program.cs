// 通常文字列
Console.WriteLine("He said, \r\n\"GOOD!\".");

// @前置
Console.WriteLine(@"He said, 
""GOOD!"".");

// $前置
int a = 1;
int b = 2;
Console.WriteLine($"{a}足す{b}は{a+b}");

// """でくくる
Console.WriteLine("""
    He said, 
    "GOOD!".
    """);

// u8を後置する (高度)
// このコードは全ての文字を安全に扱えないことに注意
ReadOnlySpan<byte> span = "He said, \r\n\"GOOD!\"."u8;
foreach (var item in span) Console.Write((char)item);
Console.WriteLine();

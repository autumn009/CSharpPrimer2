Console.WriteLine("Case A");
if (test(false, "A1") && test(true, "A2")) Console.WriteLine("True"); else Console.WriteLine("False");
Console.WriteLine("Case B");
if (test(true, "B1") && test(true, "B2")) Console.WriteLine("True"); else Console.WriteLine("False");
Console.WriteLine("Case C");
if (test(false, "C1") || test(true, "C2")) Console.WriteLine("True"); else Console.WriteLine("False");
Console.WriteLine("Case D");
if (test(true, "D1") || test(true, "D2")) Console.WriteLine("True"); else Console.WriteLine("False");

bool test(bool x, string label)
{
    Console.WriteLine($"{label}が実行されました。");
    return x;
}



for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"i={i}の場合");
    if (i == 0) Console.WriteLine("A"); Console.WriteLine("B");
    if (i == 0) { Console.WriteLine("C"); Console.WriteLine("D"); }
}
Console.WriteLine("昇順");
for (int i = 0; i < 10; i++) Console.Write(i);
Console.WriteLine();

Console.WriteLine("降順");
for (int i = 9; i >= 0; i--) Console.Write(i);
Console.WriteLine();

Console.WriteLine("無限ループ");
for (; ; )
{
    if (DateTime.Now.Second % 10 == 0)
    {
        Console.WriteLine("強制脱出!");
        break;
    }
}
Console.WriteLine("Finished!");

for (int x = 0; x < 10; x++)
{
    for (int y = 0; y < 10; y++)
    {
        Console.Write($"x={x},y={y} ");
        if (x * y > 20) goto exitLabel;
    }
}
// 以下の1行は永遠に実行されない
Console.WriteLine("Loop End");
// 以下の1行はexitLabelという名前のラベル
exitLabel:
Console.WriteLine("Done");

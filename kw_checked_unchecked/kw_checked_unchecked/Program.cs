int max = int.MaxValue;
int min = int.MinValue;
int zero = 0;
float maxf = float.MaxValue;
float minf = float.MinValue;

Console.WriteLine("unchecked context");
unchecked
{
    sub("int.MaxValue+1", () => max + 1);
    sub("int.MinValue-1", () => min - 1);
    sub("float.MaxValue+1", () => maxf + 1);
    sub("float.MinValue-1", () => minf - 1);
    sub("1/0", () => 1 / zero);
}
Console.WriteLine("checked context");
checked
{
    sub("int.MaxValue+1", () => max + 1);
    sub("int.MinValue-1", () => min - 1);
    sub("float.MaxValue+1", () => maxf + 1);
    sub("float.MinValue-1", () => minf - 1);
    sub("1/0", () => 1 / zero);
}
Console.WriteLine("checked under unchecked context");
unchecked
{
    sub("int.MaxValue+1", checked(() => max + 1));
    sub("int.MinValue-1", checked(() => min - 1));
}
Console.WriteLine("unchecked under checked context");
checked
{
    sub("int.MaxValue+1", unchecked(() => max + 1));
    sub("int.MinValue-1", unchecked(() => min - 1));
}

void sub<T>(string name, Func<T> expression)
{
    Console.Write(name);
    Console.Write(" ");
    try
    {
        var r = expression();
        Console.WriteLine($"計算終了: {r}");
    }
    catch (OverflowException)
    {
        Console.WriteLine("OverflowException例外発生!");
    }
    catch (Exception e)
    {
        Console.WriteLine($"その他の例外発生! {e.GetType().Name}");
    }
}



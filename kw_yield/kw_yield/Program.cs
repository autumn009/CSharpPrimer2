foreach (var item in DoubleCount())
{
    Console.WriteLine(item);
}

IEnumerable<int> DoubleCount()
{
    int a = 1;
    for(; ; )
    {
        if (a > 100) yield break;
        yield return a;
        a *= 2;
    }
}

var r = await sub(123,456);
Console.WriteLine($"計算結果: {r}");

async Task<int> sub(int x,int y)
{
    await Console.Out.WriteLineAsync("計算中...");
    return (x + y) / 2;
}





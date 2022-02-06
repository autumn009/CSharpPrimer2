var a = new MySample("サンプル実行");

class MySample
{
    public MySample(string message)
    {
        Console.WriteLine($"MySampleは生成されます。:{message}");
    }
    ~MySample()
    {
        Console.WriteLine("MySampleは破棄されます。");
    }
}
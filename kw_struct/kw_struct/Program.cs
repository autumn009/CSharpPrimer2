Console.WriteLine("コンストラクタが実行されるとき");
MyStruct a = new MyStruct(1);
Console.WriteLine(a.X);

Console.WriteLine("コンストラクタが実行されないとき");
MyStruct[] b = new MyStruct[1];
Console.WriteLine(b[0].X);

public struct MyStruct
{
    public int X { get; set; } = 1;
    public MyStruct()
    {
        Console.WriteLine("コンストラクタが実行されました。");
    }
    public MyStruct(int n)
    {
        Console.WriteLine("引数のあるコンストラクタが実行されました。");
        Console.WriteLine($"メンバーXを{n}にします。");
        X = n;
    }
}

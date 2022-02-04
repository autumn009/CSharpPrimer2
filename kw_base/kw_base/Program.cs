var x = new MyClassB();

class MyClassA
{
    public virtual void Sub() => Console.WriteLine("A.Sub called");
    public MyClassA(string messasge) => Console.WriteLine($"MyClassA's constructor called: {messasge}");
}

class MyClassB : MyClassA
{
    public override void Sub() => Console.WriteLine("B.Sub called");
    public MyClassB() : base("from MyClassB")
    {
        Console.WriteLine("MyClassB's constructor called");
        // 無指定のアクセス
        Sub();
        // thisアクセス
        this.Sub();
        // baseアクセス
        base.Sub();
    }
}
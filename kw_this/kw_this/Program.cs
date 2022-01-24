var a1 = new MySample();
Console.WriteLine(a1.theValue);
var a2 = new MySample(2);
Console.WriteLine(a2.theValue);

class MySample
{
    public int theValue { get; set; }
    public MySample(int theValue)
    {
        this.theValue = theValue;
        Console.WriteLine("コンストラクタ1号");
    }
    public MySample() : this(1)
    {
        Console.WriteLine("コンストラクタ2号");
    }
}


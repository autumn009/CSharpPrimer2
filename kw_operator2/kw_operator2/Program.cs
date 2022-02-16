var a = new IntPair() { X=1,Y=2};
var b = new IntPair() { X = 3, Y = 4 };
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"a+b={a + b}");

class IntPair
{
    public int X { get; set; }
    public int Y { get; set; }

    public static IntPair operator +(IntPair x, IntPair y) => new IntPair() { X = x.X + y.X, Y = x.Y + y.Y };
    public override string ToString() => $"(X:{X},Y:{Y})";
}

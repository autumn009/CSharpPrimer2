Console.WriteLine("BクラスのインスタンスをクラスAから使った時。");
A x = new B();
x.Sub1();
x.Sub2();
Console.WriteLine("BクラスのインスタンスをクラスBから使った時。");
B y = new B();
y.Sub1();
y.Sub2();

public class A
{
    public void Sub1()
    {
        Console.WriteLine("I'M A");
    }
    public virtual void Sub2()
    {
        Console.WriteLine("I'M A");
    }
}

public class B:A
{
    public new void Sub1()
    {
        Console.WriteLine("I'M B");
    }
    public override void Sub2()
    {
        Console.WriteLine("I'M B");
    }
}

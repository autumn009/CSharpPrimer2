var x = new A();
x.PublicSub();

partial class A
{
    private void privateSub()
    {
        Console.WriteLine("A.privateSub");
    }
    partial void PartialMethodA();
    partial void PartialMethodB();
}

partial class A
{
    public void PublicSub()
    {
        Console.WriteLine("A.PublicSub");
        privateSub();
        PartialMethodA();
        PartialMethodB();
    }
    partial void PartialMethodA()
    {
        Console.WriteLine("A.PartialMethodA");
    }
}

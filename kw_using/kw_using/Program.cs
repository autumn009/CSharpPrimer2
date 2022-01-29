sub1();
sub2();
sub3();

void sub1()
{
    using (var a = new MySapme())
    {
        a.Output("Pattern1");
        return;
    }
}

void sub2()
{
    using var a = new MySapme();
    a.Output("Pattern2");
    return;
}

void sub3()
{
    var a = new MySapme();
    try
    { 
        a.Output("Pattern3");
        return;
    }
    finally
    {
        Console.WriteLine("Finally!");
    }
}

class MySapme : IDisposable
{
    public void Output(string message) => Console.WriteLine(message);
    public void Dispose()
    {
        Console.WriteLine("Disposed!");
    }
}
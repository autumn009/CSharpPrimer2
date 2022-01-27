sub(new A());
sub(new B());

void sub(dynamic p)
{
    p.Say("HELLO!");
}

class A
{
    public void Say(string message) => Console.WriteLine($"{message} from A");
}

class B
{
    public void Say(string message) => Console.WriteLine($"{message} from B");
}

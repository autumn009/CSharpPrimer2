var a = new A() { Name = "Taro" };
B b = a;
C c = (C)a;
Console.WriteLine(b.Name);
Console.WriteLine(c.Name);

public class A
{
    public string? Name { get; set; }
}
public class B
{
    public string? Name { get; set; }
    public static implicit operator B(A a) => new B() { Name = a.Name };
}

public class C
{
    public string? Name { get; set; }
    public static explicit operator C(A a) => new C() { Name = a.Name };
}

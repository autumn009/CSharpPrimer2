int a = 123;
double b = 123;
string c = "Hello!";
sub(a);
sub(b);
sub(c);

void sub(object x)
{
    Console.Write($"x={x}: ");
    if (x is int)
        Console.WriteLine("それは整数型(int型)です。");
    else
        Console.WriteLine("それは私の知らない型です。");
}
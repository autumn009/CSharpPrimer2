var a = sub2(1);
sub1(a);

var b = sub2(2);
sub1(b);

void sub1(int x)
{
    if (x == 0)
    {
        Console.WriteLine("ありません。");
        return;
    }
    Console.WriteLine($"{x}個あります。");
}

int sub2(int number)
{
    if (number == 1)
    {
        return 0;
    }
    return 100;
}

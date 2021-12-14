int a = 1;
int b = 0;

Console.WriteLine("sub1を実行します。");
sub1();
Console.WriteLine("sub2を実行します。");
Console.WriteLine($"結果は{sub2()}です。");

void sub1()
{
    try
    {
        Console.WriteLine(a / b);
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"例外が起きました。例外の種類は{e.Message}です。");
    }
}

int sub2()
{
    try
    {
        return a +b;
    }
    finally
    {
        Console.WriteLine("sub2の処理はこれで終わりです。");
    }
}

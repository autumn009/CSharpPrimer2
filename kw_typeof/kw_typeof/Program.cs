Console.WriteLine($"1.GetType().FullName = {1.GetType().FullName}");
Console.WriteLine($"typeof(int).FullName = {typeof(int).FullName}");

Console.WriteLine("Tがintの場合");
sub<int>();
Console.WriteLine("Tがstringの場合");
sub<string>();

void sub<T>()
{
    Console.WriteLine($"typeof(T).FullName = {typeof(T).FullName}");
}
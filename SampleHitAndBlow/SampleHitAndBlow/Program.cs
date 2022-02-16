int target = Random.Shared.Next(9) + 1;

for (; ; )
{
    Console.WriteLine("1から10までの数を当てて下さい。");
    var val = int.Parse(Console.ReadLine() ?? "");
    if (target > val)
        Console.WriteLine("小さすぎます");
    else if (target < val)
        Console.WriteLine("大ぎます");
    else
        break;
}
Console.WriteLine("当たりです。");

Console.WriteLine("条件演算子で書く");
for (int i = 0; i < 4; i++)
{
    var label = i % 2 == 0 ? "偶数" : "奇数";
    Console.WriteLine($"{i}は{label}です。");
}
Console.WriteLine("if文で書く");
for (int i = 0; i < 4; i++)
{
    string label;
    if (i % 2 == 0)
        label = "偶数";
    else
        label = "奇数";
    Console.WriteLine($"{i}は{label}です。");
}

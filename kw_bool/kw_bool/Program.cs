bool suki = false;
for (int i = 3; i >= 1; i--)
{
    Console.WriteLine($"残り花びら{i}枚。花びらをむしります。");
    suki = !suki;
    if (suki)
        Console.WriteLine("好き");
    else
        Console.WriteLine("嫌い");
}
Console.WriteLine("残り花びらなし!");
Console.WriteLine("好き好き好き!");



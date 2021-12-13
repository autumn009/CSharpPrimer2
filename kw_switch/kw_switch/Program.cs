Console.WriteLine("swich文の場合");
for (int i = 0; i < 3; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine("ZERO");
            break;
        case 1:
            Console.WriteLine("ONE");
            break;
        default:
            Console.WriteLine("OTHERS");
            break;
    }
}
Console.WriteLine("swich式の場合");
for (int i = 0; i < 3; i++)
{
    var x = i switch
    {
        0 => "ZERO",
        1 => "ONE",
        _ => "OTHERS"
    };
    Console.WriteLine(x);
}

int x = 1;

Console.WriteLine("do文で繰り返す(その1)。");
do
{
    x *= 2; // 変数xを2倍する
    Console.Write(x);
    Console.Write(" ");
}
while (x < 100);
Console.WriteLine();

x = 1;
Console.WriteLine("while文で繰り返す(その1)。");
while (x < 100)
{
    x *= 2; // 変数xを2倍する
    Console.Write(x);
    Console.Write(" ");
};
Console.WriteLine();

x = 100;
Console.WriteLine("do文で繰り返す(その2)。");
do
{
    x *= 2; // 変数xを2倍する
    Console.Write(x);
    Console.Write(" ");
}
while (x < 100);
Console.WriteLine();

x = 100;
Console.WriteLine("while文で繰り返す(その2)。");
while (x < 100)
{
    x *= 2; // 変数xを2倍する
    Console.Write(x);
    Console.Write(" ");
};
Console.WriteLine();

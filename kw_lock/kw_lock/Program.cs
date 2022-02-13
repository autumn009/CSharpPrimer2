Console.WriteLine("lockなし");
var t = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Task.Delay(100).Wait();
        Console.Write("A");
        Task.Delay(100).Wait();
        Console.Write("B");
    }
});
t.Start();
for (int i = 0; i < 10; i++)
{
    Task.Delay(110).Wait();
    Console.Write("0");
    Task.Delay(110).Wait();
    Console.Write("1");
}
await t;

Console.WriteLine();
Console.WriteLine("lockあり");
var o = new object();
var t2 = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        lock (o)
        {
            Task.Delay(100).Wait();
            Console.Write("A");
            Task.Delay(100).Wait();
            Console.Write("B");
        }
    }
});
t2.Start();
for (int i = 0; i < 10; i++)
{
    lock (o)
    {
        Task.Delay(110).Wait();
        Console.Write("0");
        Task.Delay(110).Wait();
        Console.Write("1");
    }
}
await t2;

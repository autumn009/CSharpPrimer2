Console.WriteLine("Task.Run");
var task = Task.Run(async () =>
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(i);
        await Task.Delay(500);
    }
});
foreach (var item in "ABCDEF")
{
    Console.Write(item);
    await Task.Delay(300);
}
await task;
Console.WriteLine();
Console.WriteLine("Parallel.ForEachAsync");

await Parallel.ForEachAsync(new int[] {0,1,2,3,4,5,6,7,8,9}, new ParallelOptions(), async (number,token) =>
{
    await Task.Delay(Random.Shared.Next(1000));
    Console.Write(number);
});

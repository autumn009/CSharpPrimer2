int x = 1;
while (true)
{
    x = x * 2;
    // xが32なら即座にループの次回に進む
    if (x == 32) continue;
    // xが100より大きいならループを脱出する
    if (x > 100) break;
    Console.WriteLine(x);
}
Console.WriteLine("Finished!");
Console.WriteLine("ネストしたスコープ");
for (int i = 0; i < 2; i++)
{
    // iは使える
    var a = i * 2;
    for (int j = 0; j < 2; j++)
    {
        // aとiは使える
        var b = a * i;
        Console.Write(b);
    }
    // bはもう消滅済み
    //Console.WriteLine(b);
    Console.WriteLine();
}
// aはもう消滅済み
//Console.WriteLine(a);
// iはもう消滅済み
//Console.WriteLine(i);
// 別のi誕生
Console.WriteLine("同名の別変数");
for (int i = 0; i < 2; i++)
{
    // 別のa誕生
    string a = i.ToString();
    Console.WriteLine(a);
}
Console.WriteLine("キャプチャ例");
var doit = sub();
// 変数longLiveを使う
doit();
Action sub()
{
    var longLive = 123;
    // 変数longLiveをキャプチャ
    Action act = () => { Console.WriteLine(longLive); };
    return act;
    // ここで変数longLiveは消えるはずだがキャプチャされているので消えない
}

int a = 1;
int b = 2;

// if文を使う・実行されないとき
if (a > b) Console.WriteLine("aはbより大きい。");
// if文を使う・実行されるとき
if (b > a) Console.WriteLine("bはaより大きい。");
// エラーにならないが間違った例 (常に実行される)
if (a > b) ; Console.WriteLine("aはbより大きい。(間違った例)");
// elseも使う例
for (int i = 1; i < 3; i++)
{
    if (i > 1)
    {
        Console.WriteLine($"変数i({i})は1より大きい。");
    }
    else
    {
        Console.WriteLine($"変数i({i})は1と同じか1より小さい。");
    }
}

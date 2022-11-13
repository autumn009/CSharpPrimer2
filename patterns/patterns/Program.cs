// 宣言パターンと型パターン
// string型の場合はToLowerメソッドで小文字にして出力
object?[] array = { "ONE", 2, 3, null };
foreach (var item in array)
{
    if (item is string message) Console.WriteLine(message.ToLower());
}

// var パターン
string a = "Hello!";
var x = a is var b;
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"x={x}");

// リレーショナル パターン
// 値が3ならヒットする
for (int i = 1; i < 6; i++)
{
    var r = i switch
    {
        < 3 => "小さすぎ",
        > 3 => "大きすぎ",
        3 => "ヒット",
    };
    Console.WriteLine($"{i}は{r}。");
};

// 論理パターン1
// nullは除外
foreach (var item in array)
{
    if (item is not null) Console.WriteLine(item);
}

// 論理パターン2
// 1より大きく4より小さい値だけヒット
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i switch
    {
        > 1 and < 4 => "ヒット",
        _ => "ヒットしない"
    });
}

// プロパティ パターン
// 2030年1月だけ捜す
DateTime[] dates =
{
    new DateTime(2030,1,2),
    new DateTime(2030,2,1),
    new DateTime(2031,1,1),
};
foreach (var item in dates)
{
    if (item is { Year: 2030, Month: 1 }) Console.WriteLine($"{item}: ヒット");
}

// かっこで囲まれたパターン
// long型の値123Lは32bit整数か?　(違う。64bit整数だ)
// intは32bit符号付き整数、uintは32bit符号なし整数。特殊な型を除いて通常はこの2つが32bit整数
object v = 123L;
if (v is not (int or uint)) Console.WriteLine("32bit整数ではない");

// リスト・パターン
int[] array2 = { 1, 2, 3 };
if (array2 is [>= 0, >= 0, >= 0]) Console.WriteLine("array2は全て正の値で要素は3個です。");
if (array2 is [var first, .. var rest])
{
    Console.WriteLine($"array2の最初の値は{first}です。");
    Console.WriteLine($"array2の残りの値は{rest.Length}個です。");
}

sub((x, y) => (x + y).ToString());
subF((x, y) => (x + y).ToString());

// 自分で定義したデリゲート型を使った時
void sub(TwoInt proc)
{
    Console.WriteLine(proc(1, 2));
}
// 定義済みのFunc型を使ったとき
void subF(Func<int,int, string> proc)
{
    Console.WriteLine(proc(1, 2));
}

// デリゲート型の宣言
delegate string TwoInt(int x, int y);

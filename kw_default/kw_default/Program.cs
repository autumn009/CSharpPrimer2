int a = 1;
int[] b = new int[1];
int c = default(int);
if (a == default)
    Console.WriteLine("aはデフォルト値だよ。");
else
    Console.WriteLine("aはデフォルト値じゃないよ。");

if (b[0] == default)
    Console.WriteLine("b[0]はデフォルト値だよ。");
else
    Console.WriteLine("b[0]はデフォルト値じゃないよ。");

if (c == default)
    Console.WriteLine("cはデフォルト値だよ。");
else
    Console.WriteLine("cはデフォルト値じゃないよ。");

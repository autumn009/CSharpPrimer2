// コメント
sub(); // 自作のメソッド呼び出し
for (int i = 0; i < 10; i++) Console.Write(i);  // forは組み込みステートメント
Console.WriteLine("Hello, World!"); // ライブラリのメソッド呼び出し

// 自作メソッド本体
static void sub() => Console.WriteLine("Hello from sub method");

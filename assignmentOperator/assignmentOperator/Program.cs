int[] array = new int[1];
array[0] = 123;
Console.WriteLine($"array[0]={array[0]}");
int x;
int[] y;
// 値型の代入
x = array[0];
// 参照型の代入
y = array;
Console.WriteLine("値の更新　(参照は更新しない)");
array[0] = 456;
Console.WriteLine($"array[0]={array[0]}");
Console.WriteLine($"x={x}");
Console.WriteLine($"y={y[0]}");

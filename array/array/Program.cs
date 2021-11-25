Console.WriteLine("1次元配列");
int[] array1 = new int [10];
for (int i = 0; i < 10; i++) array1[i] = (i+1) * (i + 1);
for (int i = 0; i < 10; i++) Console.Write($"{array1[i]} ");
Console.WriteLine();

Console.WriteLine("2次元配列");
int[,] array2 = new int[3,3];
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        array2[i,j] = (i+1) * (j+1);
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write($"{array2[i, j]} ");
    Console.WriteLine();
}

Console.WriteLine("配列の配列");
int[][] arrayOfArray = new int[3][];
for (int i = 0; i < 3; i++)
    arrayOfArray[i] = new int[i];
for (int i = 0; i < 3; i++)
    Console.WriteLine($"配列[{i}]サイズ={arrayOfArray[i].Length} ");

// インデクサの利用例
string s = "Hello!";
Console.WriteLine($"{s}の4文字目は{s[3]}です。");

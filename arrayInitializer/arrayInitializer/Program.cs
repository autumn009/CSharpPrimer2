Console.WriteLine("CASE1");
int[] array1 = new int[] { 2, 3, 5 };
foreach (var item in array1) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("CASE2");
int[] array2 = { 2, 3, 5 };
foreach (var item in array2) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("CASE3");
int[,] array3 = { { 2, 3, 5 }, { 7, 11, 13 } };
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write($"{array3[i,j]} ");
    }
    Console.WriteLine();
}



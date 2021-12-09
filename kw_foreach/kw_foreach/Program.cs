string[] myArray = new string[3];
myArray[0] = "たろう";
myArray[1] = "ジョー";
myArray[2] = "ねこ";
foreach (var item in myArray)
{
    Console.WriteLine($"{item}さん、ハロー!");
}

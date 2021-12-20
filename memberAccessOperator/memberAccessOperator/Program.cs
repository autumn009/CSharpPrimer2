Console.WriteLine("文字列合体!");
string[] array = new string[] { "ONE", "TWO", "THREE" };
var r1 = string.Join(",", array);
Console.WriteLine(r1);

Console.WriteLine("文字列分離!");
string[] r2 = r1.Split(',');
foreach (var item in r2) Console.WriteLine($"{item}");

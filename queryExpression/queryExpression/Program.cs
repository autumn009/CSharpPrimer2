string[] array = { "Alice", "Betty", "Aiko", "Cindy", "Abbie" };

Console.WriteLine("クエリ式の例");
var q1 = from n in array where n.StartsWith("A") orderby n select n.ToUpper();
foreach (var item in q1) Console.WriteLine(item);

Console.WriteLine("メソッド形式の例");
var q2 = array.Where(c=>c.StartsWith("A")).OrderBy(c=>c).Select(c=>c.ToUpper());
foreach (var item in q2) Console.WriteLine(item);

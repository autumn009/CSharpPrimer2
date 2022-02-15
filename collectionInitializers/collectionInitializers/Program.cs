var list= new List<int> { 123, 456, 789 };
foreach (var item in list) Console.WriteLine(item);
var dic1 = new Dictionary<string, string> 
{
    {"Key1","value1" },
    {"Key2","value2" }
};
foreach (var item in dic1.Keys) Console.WriteLine($"{item}={dic1[item]}");
var dic2 = new Dictionary<string, string>
{
    ["Key1"] = "value1",
    ["Key2"] = "value2",
};
foreach (var item in dic2.Keys) Console.WriteLine($"{item}={dic2[item]}");

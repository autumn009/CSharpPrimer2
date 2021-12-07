var theDay = new DateTime(2029,1,5);
Console.WriteLine(theDay.DayOfWeek);
if (theDay.DayOfWeek == DayOfWeek.Friday) Console.WriteLine("金曜日はゴミの日です。");

Console.WriteLine($"Sex.男={Sex.男}");
Console.WriteLine($"(int)Sex.男={(int)Sex.男}");

for (int i = 0; i < 3; i++)
{
    Sex theMan = (Sex)i;
    Console.WriteLine($"俺は{theMan}だ!");
}

enum Sex { 女, 男, その他 }

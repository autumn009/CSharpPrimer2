var p = new Place[3];
p[0] = new Place();
p[0].Name = "電気街";
p[0].Station = "秋葉原駅";
p[1] = new Place();
p[1].Name = "有明コロシアム";
p[1].Station = "国際展示場駅";
p[2] = new Place();
p[2].Name = "目黒天空庭園";
p[2].Station = "池尻大橋駅";

foreach (var item in p) Console.WriteLine($"{item.Name}の最寄り駅は {item.Station}");

public class Place
{
    public string? Name { get; set; }
    public string? Station { get; set; }
}

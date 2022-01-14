var papa = new Person();
papa.Name = "ウルトラの父";

var boku = new Student();
boku.Name = "ウルトラのタロウ";
boku.SchoolName = "ウルトラ小学校";

var man = new SuperMan();
man.Name = "スーパー紅茶マン";
man.CameFrom = "リプトン星";

outputCommon(papa);
outputCommon(boku);
outputCommon(man);

void outputCommon(Person p)
{
    Console.WriteLine($"あいつの名前は{p.Name}");
}

public class Person
{
    public string? Name { get; set; }
}

// まだまだここから継承できる
public class Student: Person
{
    public string? SchoolName;
}

// もうここから継承できない
public sealed class SuperMan : Person
{
    public string? CameFrom;
}

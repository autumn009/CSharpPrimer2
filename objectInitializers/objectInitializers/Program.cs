var papa = new SamplePerson() { Name = "Kenji", Age = 40 };
// ↓できない　(initだから)
// papa.Name = "Kentaro";
// ↓できる　(setだから)
papa.Age = 41;
Console.WriteLine($"{papa.Name}は{papa.Age}歳");

class SamplePerson
{
    public string? Name { get; init; }
    public int Age { get; set; }
}


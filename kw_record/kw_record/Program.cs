var taro = new Person("山田", "太郎");
Console.WriteLine($"{taro.FirstName}{taro.LastName}");
// 以下はできない
// taro.FirstName = "ウルトラマン";
taro = taro with { FirstName="ウルトラマン" };
Console.WriteLine($"{taro.FirstName}{taro.LastName}");

public record Person(string FirstName, string LastName);

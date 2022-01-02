myMethod("普通に呼ぶぞ");

Action<string> myVar = myMethod;
myVar("変数経由で呼ぶぞ");

var myArray = new Action<string>[] { myMethod };
myArray[123 + 456 - 579]("配列経由で呼ぶぞ");

void myMethod(string message)
{
    Console.WriteLine($"myMethod called: {message}");
}
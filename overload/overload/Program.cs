var x = new MySample();
x.SetMessage();
Console.WriteLine(x.MyMessage);
x.SetMessage(1);
Console.WriteLine(x.MyMessage);
x.SetMessage(123,456);
Console.WriteLine(x.MyMessage);
x.SetMessage("Hello World");
Console.WriteLine(x.MyMessage);


class MySample
{
    public string MyMessage { get; set; }
    public void SetMessage()
    {
        MyMessage = "ハロー";
    }
    public void SetMessage(int x)
    {
        MyMessage = $"x={x}";
    }
    public void SetMessage(int x, int y)
    {
        MyMessage = $"x={x} y={y}";
    }
    public void SetMessage(string message)
    {
        MyMessage = message;
    }
}

string s = "オレのおじさん";
Console.WriteLine($"変換前: {s}");
Console.WriteLine($"変換後: {s.ToOrego()}");

public static class MyExtensions
{
    public static string ToOrego(this string str)
    {
        return str.Replace("オ", "レレ");
    }
}
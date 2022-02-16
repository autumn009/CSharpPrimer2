Console.WriteLine("暗号化します");
var s1 = rot13("The quick brown fox jumps over the lazy dog");
Console.WriteLine(s1);
Console.WriteLine("解読します");
var s2 = rot13(s1);
Console.WriteLine(s2);

string rot13(string text)
{
    string r = "";
    foreach (var item in text)
    {
        if (item >= 'A' && item <= 'Z')
            r += (char)((item - 'A' + 13) % 26 + 'A');
        else if (item >= 'a' && item <= 'z')
            r += (char)((item - 'a' + 13) % 26 + 'a');
        else
            r += item;
    }
    return r;
}

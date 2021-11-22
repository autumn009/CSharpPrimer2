Console.OutputEncoding = System.Text.Encoding.UTF8;
string s1 = "あ";    // これは文字列です
char c1 = 'あ';   // これは文字です。
Console.WriteLine($"{s1} 長さ{s1.Length}");
Console.WriteLine($"{c1} 番号{(int)c1}");
string s2 = "😀";
//char c2 = '😀';    // エラーになります
Console.WriteLine($"{s2} 長さ{s2.Length}");
string s3 = "LUCKY";
foreach (char ch in s3) Console.WriteLine($"{ch} 番号{(int)ch}");

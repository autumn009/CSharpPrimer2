const string name = "カルメン";

// 方法1 単純結合法
string s1 = "私の名前は" + name + "です。";
Console.WriteLine(s1);

// 方法2 書式文字列法
string s2 = $"私の名前は{ name }です。";
Console.WriteLine(s2);

// 方法3 string.Concat法
string s3 = string.Concat("私の名前は", name, "です。");
Console.WriteLine(s3);

// 方法4 string.Format法
string s4 = string.Format("私の名前は{0}です。", name);
Console.WriteLine(s4);

// 方法5 Console.WriteLine法
Console.WriteLine("私の名前は{0}です。", name);

// 方法6 StringBuilder+Append法
var sb1 = new System.Text.StringBuilder();
sb1.Append("私の名前は");
sb1.Append(name);
sb1.Append("です。");
Console.WriteLine(sb1.ToString());
Console.WriteLine(sb1);

// 方法7 StringBuilder+AppendFormat法
var sb2 = new System.Text.StringBuilder();
sb2.AppendFormat("私の名前は{0}です。", name);
Console.WriteLine(sb2.ToString());
Console.WriteLine(sb2);

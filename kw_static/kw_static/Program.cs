Console.WriteLine(MyStaticSample.MyPropertyStatic);
MyStaticSample.SetPropertyToStatic(2);
Console.WriteLine(MyStaticSample.MyPropertyStatic);

public class MyStaticSample
{
    // 静的なプロパティ
    public static int MyPropertyStatic { get; set; }
    // 静的なメソッド
    public static void SetPropertyToStatic(int x)
    {
        MyPropertyStatic = x;
    }
    // 静的なコンストラクタ
    static MyStaticSample()
    {
        MyPropertyStatic = 1;
    }
}
var x = new MySample();
x.NameByField = "フィーちゃん";
x.NameByProperty = "プロパちゃん";
Console.WriteLine($"x.NameByField={x.NameByField}");
Console.WriteLine($"x.NameByProperty={x.NameByProperty}");
Console.WriteLine($"x.NameByFullProperty={x.NameByFullProperty}");
Console.WriteLine($"x.NameByExpressionProperty={x.NameByExpressionProperty}");
Console.WriteLine($"x.NameByReadOnlyField={x.NameByReadOnlyField}");
Console.WriteLine($"x.NameByReadOnlyProperty={x.NameByReadOnlyProperty}");
Console.WriteLine($"x.NameByReadOnlyExpressionProperty={x.NameByReadOnlyExpressionProperty}");

class MySample
{
    // フィールドの例
    public string NameByField = "フィールド";

    public string NameByProperty { get; set; } = "プロパティ";

    // 内容を含むプロパティの例
    private string nameByFullProperty = "プロパティで読み出すフィールド";
    public string NameByFullProperty { get { return nameByFullProperty; } set { nameByFullProperty = value; } }

    // 内容を含むプロパティの式形式の例
    public string NameByExpressionProperty { get => nameByFullProperty; set => nameByFullProperty = value; }

    // 読み出し専用フィールドの例
    public readonly string NameByReadOnlyField = "読み出し専用フィールド";

    // 読み出し専用プロパティの例
    public string NameByReadOnlyProperty { get; } = "読み出し専用プロパティ";

    // 読み出し専用プロパティの式形式の例
    public string NameByReadOnlyExpressionProperty { get => "読み出し専用プロパティ"; }
}
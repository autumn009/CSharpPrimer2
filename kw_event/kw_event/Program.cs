var a = new SampleClass();
// イベントの登録
a.OnNotify += (sender, e) =>
{
    Console.WriteLine($"オブジェクトaでイベント発生! 理由:{e.Message}");
};
a.SampleMethod();

// イベントの情報を持つクラス
public class MyEventArgs : EventArgs
{
    public string? Message { get; set; }
}

// イベントを持つクラス
public class SampleClass
{
    public event EventHandler<MyEventArgs>? OnNotify;
    public void SampleMethod()
    {
        // イベント発生
        if (OnNotify != null) OnNotify(this, new MyEventArgs() { Message = "SampleMethodが呼ばれました" }) ;
    }
}

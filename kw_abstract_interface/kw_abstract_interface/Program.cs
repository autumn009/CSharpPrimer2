var x1 = new SampleB();
x1.sub();
var x2 = new SampleD();
x2.sub();
var x3 = new SampleE();
((ISampleC)x3).sub();

abstract class SampleA
{
    public abstract void sub();
}

// 抽象クラスの実装
class SampleB : SampleA
{
    public override void sub() => Console.WriteLine("I'm ClassB.A");
}

interface ISampleC
{
    void sub();
}

// インターフェースの実装
class SampleD : ISampleC
{
    public void sub() => Console.WriteLine("I'm ClassD.A");
}

// インターフェースの明示的な実装
class SampleE : ISampleC
{
    void ISampleC.sub() => Console.WriteLine("I'm ClassE.A");
}

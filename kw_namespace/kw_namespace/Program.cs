using NamespaceBeta;

var x = new NamespaceAlpha.MySample();
x.Sub();
var y = new MySample();
y.Sub();

namespace NamespaceAlpha
{
    public class MySample
    {
        public void Sub()
        {
            Console.WriteLine("I'm NamespaceAlpha.MySample.Sub()");
        }
    }
}

namespace NamespaceBeta
{
    public class MySample
    {
        public void Sub()
        {
            Console.WriteLine("I'm NamespaceBeta.MySample.Sub()");
        }
    }
}
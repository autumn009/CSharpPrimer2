int x = 1;
for (int i = 0; i < 8; i++)
{
    if (x > 100) throw new MySampleException("xが100を超えました。");
    x *= 2;
}

[Serializable]
public class MySampleException : Exception
{
    public MySampleException() : base() { }
    public MySampleException(string message) : base(message) { }
    public MySampleException(string message, Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client.
    protected MySampleException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

sub<sbyte>("sbyte", sbyte.MaxValue, sbyte.MinValue);
sub<short>("short", short.MaxValue, short.MinValue);
sub<int>("int", int.MaxValue, int.MinValue);
sub<nint>("nint", nint.MaxValue, nint.MinValue);
sub<long>("long", long.MaxValue, long.MinValue);
sub<byte>("byte", byte.MaxValue, byte.MinValue);
sub<ushort>("ushort", ushort.MaxValue, ushort.MinValue);
sub<uint>("uint", uint.MaxValue, uint.MinValue);
sub<nuint>("nuint", nuint.MaxValue, nuint.MinValue);
sub<ulong>("ulong", ulong.MaxValue, ulong.MinValue);

static void sub<T>(string name, T max, T min) => Console.WriteLine($"名前:{name,-10} 本名:{typeof(T).FullName,-14} 最大値:{max,22} 最小値:{min,22}");